using API.Persistence;
using Microsoft.EntityFrameworkCore;
using Timer = System.Timers.Timer;
using ElapsedEventHandler = System.Timers.ElapsedEventHandler;
using ElapsedEventArgs = System.Timers.ElapsedEventArgs;

namespace API.Services
{
    public class UpdateService : BackgroundService
    {
        private readonly IConfiguration config;
        private readonly IServiceScopeFactory scopeFactory;
        private Timer _timer;
        private double updateIntervalInSeconds;
        private double timeSinceStart = 0;

        public UpdateService(IConfiguration config, IServiceScopeFactory scopeFactory)
        {
            this.config = config;
            this.scopeFactory = scopeFactory;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                updateIntervalInSeconds = Convert.ToInt32(config["BackgroundServices:UpdateIntervalInSeconds"]);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                updateIntervalInSeconds = 5;
            }
            _timer = new Timer();
            _timer.Elapsed += new ElapsedEventHandler(StartUpdate);
            _timer!.Interval = TimeSpan.FromSeconds(updateIntervalInSeconds).TotalMilliseconds;
            _timer.Enabled = true;

            return Task.CompletedTask;
        }

        private async void StartUpdate(object source, ElapsedEventArgs e)
        {
            // Time the function started at
            var currentTime = DateTime.UtcNow;

            using (var scope = scopeFactory.CreateScope())
            {
                var betaContext = scope.ServiceProvider.GetRequiredService<BetaContext>();
                // Get list of unique base ids that have upgrades
                var baseIds = await betaContext.Upgrades.DistinctBy(u => u.BaseId).Select(u => u.BaseId).ToListAsync();
                // Return if there aren't any upgrades
                if (! baseIds.Any()) return;
                // Loop through base id list
                baseIds.ForEach(async baseId =>
                {
                    // Get the queue for this building
                    var queue = await betaContext.Upgrades.Where(u => u.BaseId == baseId).OrderBy(q => q.Queue).ToListAsync();
                    // If no queue items exist, there is nothing to do for this queue
                    if (! queue.Any()) return;
                    // Check if first queue has started
                    var headItem = queue.First();
                    // If nothing has been started yet, the item has started between the last and current intervals
                    if (headItem.StartTime == null)
                    {
                        // The time passed can at most be the updateIntervalInSeconds + timeSinceStart
                        // Calculate max time
                        double maxTime = updateIntervalInSeconds + timeSinceStart;
                        // Calculate time since creation
                        double timeSinceCreation = (currentTime - headItem.CreationTime).TotalSeconds;
                        // Get the minimum value from the two to get the actual time
                        double actualTimeCompleted = GetMinValue(maxTime, timeSinceCreation);
                        // TODO: Check if actualTimeCompleted is more than the upgrade time
                        // TODO: If true, then add the additional time to a new object based off of currentTime
                            // TODO: Apply completed task
                            // TODO: Delete completed task
                            // TODO: Set the next item's start time to the calculated dateTime
                    }
                    else
                    {
                        // The item has already started, calculate time completed since start time, validate whether the upgrade has completed
                    }
                });

                // calculate time past since the function started
                timeSinceStart = (DateTime.UtcNow - currentTime).TotalSeconds;
            }
        }

        private double GetMinValue(double a, double b)
        {
            return Math.Min(a, b);
        }
    }
}
