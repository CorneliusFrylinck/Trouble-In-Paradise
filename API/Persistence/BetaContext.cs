using API.Domain;
using API.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace API.Persistence
{
    /// <summary>
    /// Context for beta server database.
    /// </summary>
    public class BetaContext: DbContext
    {
        public BetaContext(DbContextOptions<BetaContext> options) : base(options) { }

        public DbSet<Base> Bases { get; set; } = null!;
        public DbSet<Building> Buildings { get; set; } = null!;
        public DbSet<ResourceItem> ResourceItems { get; set; } = null!;
        public DbSet<ResourceStore> ResourceStores { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Description> Descriptions { get; set; } = null!;
        public DbSet<UpgradeDetail> UpgradeDetails { get; set; } = null!;
        public DbSet<Upgrade> Upgrades { get; set; } = null!;

        /// <summary>
        /// Seed data on model creation.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite key for upgrades, as each base has their own queue for upgrades
            modelBuilder.Entity<Upgrade>().HasKey(u => new { u.BaseId, u.Queue });

            modelBuilder.SeedTestUser();
            modelBuilder.SeedStaticData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
