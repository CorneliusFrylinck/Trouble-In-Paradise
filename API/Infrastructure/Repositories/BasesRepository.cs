using API.Data;
using API.Domain;
using API.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Versioning;

namespace API.Infrastructure.Repositories
{
    /// <summary>
    /// Repository used to handle the database communication.
    /// 
    /// NOTE: once multiple databases get used this is where it will be managed.
    /// NOTE: interface is used to keep me honest, it keeps a nice view of the available that's easy to check and judge without having to look for the code between the functions.
    /// </summary>
    public class BasesRepository: IBasesRepository
    {
        private readonly IEventsRepository eventsRepository;

        private BetaContext betaContext { get; }

        public BasesRepository(BetaContext betaContext, IEventsRepository eventsRepository)
        {
            this.betaContext = betaContext;
            this.eventsRepository = eventsRepository;
        }

        /// <summary>
        /// Function to get a base by id.
        /// TODO: After players are added, add a function to get base names by player id. Possibility: create Dto that holds the active base, and the names of the other bases.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Base</returns>
        public async Task<Base?> GetBaseByIdAsync(int id)
        {
            // When retrieving base data, the resource stores should first be updated to ensure that the latest data is shown to the player.
            await eventsRepository.UpdateResourceStoreEventAsync(id);
            return await betaContext.Bases.Where(b => b.Id == id).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Function to get a base's resource store by base id.
        /// </summary>
        /// <param name="baseId"></param>
        /// <returns>Resource Store</returns>
        public async Task<ResourceStore?> GetBaseResourceStoreByBaseIdAsync(int baseId)
        {
            // When retrieving base data, the resource stores should first be updated to ensure that the latest data is shown to the player.
            await eventsRepository.UpdateResourceStoreEventAsync(baseId);

            var currentBase = await betaContext.Bases.Where(b => b.Id == baseId).FirstOrDefaultAsync();

            if (currentBase == null) return null;

            return currentBase.Resources;
        }

        /// <summary>
        /// Function to get a base's resource production rates by base id.
        /// </summary>
        /// <param name="baseId"></param>
        /// <returns>Hourly Resource Production Rate</returns>
        public async Task<ResourceProductionRequestDto?> GetBaseResourceProductionRatesByBaseIdAsync(int baseId)
        {
            var currentBase = await betaContext.Bases.Where(b => b.Id == baseId).FirstOrDefaultAsync();

            if (currentBase == null) return null;

            // Get production speeds for all resources. This is done by filtering the resource buildings by the base id and 
            //      resource type to get all relevant buildings, then summing their productions.
            var waterProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == currentBase.Id && r.Type == ResourceEnum.Water)
                .SumAsync(s => s.ProductionSpeed);
            var foodProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == currentBase.Id && r.Type == ResourceEnum.Food)
                .SumAsync(s => s.ProductionSpeed);
            var lumberProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == currentBase.Id && r.Type == ResourceEnum.Lumber)
                .SumAsync(s => s.ProductionSpeed);
            var cementProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == currentBase.Id && r.Type == ResourceEnum.Cement)
                .SumAsync(s => s.ProductionSpeed);
            var oxygenProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == currentBase.Id && r.Type == ResourceEnum.Oxygen)
                .SumAsync(s => s.ProductionSpeed);
            var metalProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == currentBase.Id && r.Type == ResourceEnum.Metal)
                .SumAsync(s => s.ProductionSpeed);
            var goldProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == currentBase.Id && r.Type == ResourceEnum.Gold)
                .SumAsync(s => s.ProductionSpeed);
            var blueCrystalProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == currentBase.Id && r.Type == ResourceEnum.Crystal_Blue)
                .SumAsync(s => s.ProductionSpeed);
            var redCrystalProduction =
                await betaContext.ResourceItems.Where(r => r.BaseId == currentBase.Id && r.Type == ResourceEnum.Crystal_Red)
                .SumAsync(s => s.ProductionSpeed);

            return new ResourceProductionRequestDto()
            {
                Water = waterProduction,
                Cement = cementProduction,
                Crystal_Blue = blueCrystalProduction,
                Crystal_Red = redCrystalProduction,
                Metal = metalProduction,
                Food = foodProduction,
                Gold = goldProduction,
                Lumber = lumberProduction,
                Oxygen = oxygenProduction
            };
        }
    }
}
