using System.ComponentModel.DataAnnotations;

namespace API.Domain
{
    public class Upgrade
    {
        /// <summary>
        /// Base on which the upgrade will occur.
        /// </summary>
        public int BaseId { get; set; }
        /// <summary>
        /// Upgrade's position in the queue.
        /// </summary>
        public int Queue { get; set; }
        /// <summary>
        /// Building to upgrade.
        /// </summary>
        public int BuildingId { get; set; }
        /// <summary>
        /// Time to complete the upgrade.
        /// </summary>
        public int TimeInSeconds { get; set; }
        /// <summary>
        /// The time that the upgrade has started, set on the UpgradeService.
        /// </summary>
        public DateTime? StartTime { get; set; } = null!;
        /// <summary>
        /// The time that the upgrade has created.
        /// </summary>
        public DateTime CreationTime { get; set; } = DateTime.UtcNow;
    }
}
