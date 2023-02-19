using API.Persistence;
using Microsoft.EntityFrameworkCore;
using Timer = System.Timers.Timer;

namespace API.Services
{
    public class UpdateService : BackgroundService
    {
        private readonly IConfiguration config;
        private readonly IServiceScopeFactory scopeFactory;
        private Timer? _timer = new Timer();
        private int updateTimeInSeconds;

        public UpdateService(IConfiguration config, IServiceScopeFactory scopeFactory)
        {
            this.config = config;
            this.scopeFactory = scopeFactory;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                updateTimeInSeconds = Convert.ToInt32(config["BackgroundServices:UpdateTimeInSeconds"]);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                updateTimeInSeconds = 1;
            }

            _timer!.Interval = TimeSpan.FromSeconds(updateTimeInSeconds).TotalMilliseconds;

            StartUpdate();

            return Task.CompletedTask;
        }

        private void StartUpdate()
        {
            // NOTE: Either loop through bases and check everything, or start a separate timer for every event

            using (var scope = scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<BetaContext>();
                // TODO: Get list of unique bases that have upgrades
                // TODO: Loop through base list
                // TODO: Find completed tasks if any
                // TODO: Fullfill completion if any
                // TODO: Delete completed task
                // TODO: Start the next task
            }
        }
    }
}
