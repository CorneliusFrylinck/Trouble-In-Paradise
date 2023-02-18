using API.Persistence;
using API.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Infrastructure.Repositories
{
    public class EventsRepository : IEventsRepository
    {
        private readonly BetaContext betaContext;

        public EventsRepository(BetaContext betaContext)
        {
            this.betaContext = betaContext;
        }

        /// <summary>
        /// Function to update a base's resource store.
        /// TODO: Check for potential refactors.
        /// </summary>
        /// <param name="baseId"></param>
        /// <returns>True if the update was successful.</returns>
        /// <returns>False if something went wrong.</returns>
        public async Task<bool> UpdateResourceStoreEventAsync(int baseId)
        {
            // Verify that base exists.
            var currentBase = await betaContext.Bases.Where(b => b.Id == baseId).FirstOrDefaultAsync();
            if (currentBase == null) return false;

            // If the resource store doesn't exist yet, create it. This would likely only be when a base is initially created.
            if (currentBase.Resources == null)
            {
                currentBase.Resources = new ResourceStore();
                // If memory serves this is required to actually save the data.
                // TODO: Verify necessity when refactoring.
                await betaContext.SaveChangesAsync();

                // Create initial resource update event.
                await CreateEvent(currentBase.Resources.Id, EventTypeEnum.ResourceUpdate);
                return true;
            }

            // Retrieve last resource update event to calculate the amount of seconds since the resource production has been updated.
            // Related id refers to the Resource Id in this case.
            var lastResourceUpdateEvent = 
                await betaContext.Events.Where(e => e.RelatedId == currentBase.Resources.Id && e.EventType == EventTypeEnum.ResourceUpdate)
                .OrderByDescending(o => o.Id).FirstOrDefaultAsync();

            double seconds = -1;
            if (lastResourceUpdateEvent != null)
            {
                // If the event exists, use the event time to determine the production seconds to calculate.
                seconds = GetSecondDiff(lastResourceUpdateEvent!.EventOccurrence);

                // Return true if there isn't anything to update.
                if (seconds == 0) return true;
            }else
            {
                // If there isn't an event yet (should only happen if something went wrong with initial event creation)
                //      then use the date of the base creation.
                seconds = GetSecondDiff(currentBase.Created);
            }
            // Create next event.
            await CreateEvent(currentBase.Resources.Id, EventTypeEnum.ResourceUpdate);

            // Helper function to get the updated resource values.
            currentBase.Resources = await GetUpdatedResourceStore(currentBase.Resources, seconds);
            await betaContext.SaveChangesAsync();

            return true;
        }

        private double GetSecondDiff(DateTime oldTime)
        {
            var currentTime = DateTime.UtcNow;
            TimeSpan timeSpan = currentTime - oldTime;

            return timeSpan.TotalSeconds;
        }

        private async Task CreateEvent(int relatedId, EventTypeEnum eventType)
        {
            await betaContext.Events.AddAsync(new Event()
            {
                RelatedId = relatedId,
                EventType = eventType
            });

            await betaContext.SaveChangesAsync();
        }

        private async Task<ResourceStore> GetUpdatedResourceStore(ResourceStore resourceStore, double secondsToUpdate)
        {
            // Get production speeds for all resources. This is done by filtering the resource buildings by the base id and 
            //      resource type to get all relevant buildings, then summing their productions.
            var waterProduction = 
                await betaContext.ResourceItems.Where(r => r.BaseId == resourceStore.BaseId && r.Type == ResourceEnum.Water)
                .SumAsync(s => s.ProductionSpeed);
            var foodProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == resourceStore.BaseId && r.Type == ResourceEnum.Food)
                .SumAsync(s => s.ProductionSpeed);
            var lumberProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == resourceStore.BaseId && r.Type == ResourceEnum.Lumber)
                .SumAsync(s => s.ProductionSpeed);
            var cementProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == resourceStore.BaseId && r.Type == ResourceEnum.Cement)
                .SumAsync(s => s.ProductionSpeed);
            var oxygenProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == resourceStore.BaseId && r.Type == ResourceEnum.Oxygen)
                .SumAsync(s => s.ProductionSpeed);
            var metalProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == resourceStore.BaseId && r.Type == ResourceEnum.Metal)
                .SumAsync(s => s.ProductionSpeed);
            var goldProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == resourceStore.BaseId && r.Type == ResourceEnum.Gold)
                .SumAsync(s => s.ProductionSpeed);
            var blueCrystalProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == resourceStore.BaseId && r.Type == ResourceEnum.Blue_Crystal)
                .SumAsync(s => s.ProductionSpeed);
            var redCrystalProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == resourceStore.BaseId && r.Type == ResourceEnum.Red_Crystal)
                .SumAsync(s => s.ProductionSpeed);

            // Calculate how much of each resource has been produced since the last event time.
            // Production speed is in hours, divide by 60 => minute, divide by 60 => seconds. Then multiply by seconds to update.
            var newResource = new ResourceStore(resourceStore.BaseId, resourceStore.Id)
            {
                Food = resourceStore.Food + ((foodProduction / 60 / 60) * secondsToUpdate),
                Water = resourceStore.Water + ((waterProduction / 60 / 60) * secondsToUpdate),
                Metal = resourceStore.Metal + ((metalProduction / 60 / 60) * secondsToUpdate),
                Lumber = resourceStore.Lumber + ((lumberProduction / 60 / 60) * secondsToUpdate),
                Cement = resourceStore.Cement + ((cementProduction / 60 / 60) * secondsToUpdate),
                Oxygen = resourceStore.Oxygen + ((oxygenProduction / 60 / 60) * secondsToUpdate),
                Blue_Crystal = resourceStore.Blue_Crystal + ((blueCrystalProduction / 60 / 60) * secondsToUpdate),
                Red_Crystal = resourceStore.Red_Crystal + ((redCrystalProduction / 60 / 60) * secondsToUpdate),
                Gold = resourceStore.Gold + ((goldProduction / 60 / 60) * secondsToUpdate),
            };

            return newResource;
        }
    }
}
