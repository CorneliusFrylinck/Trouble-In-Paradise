using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Data
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

        /// <summary>
        /// Seed data on model creation.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            int buildingId = 1;

            modelBuilder.Entity<Base>().HasData(
                new Base("Base 1", "Just a test bois")
                {
                    Id = 1,
                    BaseX = 200,
                    BaseY = 200,
                }
            );
            modelBuilder.Entity<ResourceStore>().HasData(new ResourceStore(1, 1));
            modelBuilder.Entity<ResourceItem>().HasData(
                new ResourceItem("Cement", "Resource used for building and upgrading buildings.", 0, 100, 1, 1),
                new ResourceItem("Metal", "Resource used for building and upgrading buildings, and units..", 0, 100, 1, 2),
                new ResourceItem("Lumber", "Resource used for building and upgrading buildings.", 0, 100, 1, 3),
                new ResourceItem("Water", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, 100, 1, 4),
                new ResourceItem("Food", "Resource used to keep units and workers alive.", 0, 100, 1, 5),
                new ResourceItem("Oxygen", "Resource used for building and upgrading buildings.", 0, 100, 1, 6),
                new ResourceItem("Crystal_Blue", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, 100, 1, 7),
                new ResourceItem("Crystal_Red", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 0, 100, 1, 8),
                new ResourceItem("Gold", "Resource rarely found in mines. Used to queue building and unit upgrades", 0, 5, 1, 9)
            );
            modelBuilder.Entity<Building>().HasData(
                new Building("Command Centre", "This is your center of communication. Upgrading this building can also unlock new options on other buildings.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Guild Hub", "This is where you can create a guild, join a guild, communicate with your guild and access guild-related actions.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Barracks", "This is where you build your army. Build units and assign them to squads.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Warroom", "This is where you manage your army. Send your squads out to attack, move them strategically or assign them to train and get stronger.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Navigational Unit", "This building is used to view the area around you.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Radar", "This building picks up enemy attacks and any troop movement to your base.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Medical Facility", "This building is used to heal your troops after they get hurt.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Research Facility", "This building is used to unlock new units and abilities.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Tradepost", "This building is used to send resources to other players.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Market", "This building is used to trade resources with locals of the new planet.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Silos", "Upgrade these buildings to increase your resource storage capabilities.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Vaults", "These buildings are used to protect your resources from raiders.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Bunkers", "These buildings offer protection to your ranged units when defending.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Shield", "Your shield offers all units and buildings protection when you are being attacked.", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
