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
        public DbSet<Description> Descriptions { get; set; } = null!;

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
                new ResourceItem("Cement", 0, 1000, 1, 1),
                new ResourceItem("Metal", 0, 1000, 1, 2),
                new ResourceItem("Lumber", 0, 1000, 1, 3),
                new ResourceItem("Water", 0, 1000, 1, 4),
                new ResourceItem("Food", 0, 1000, 1, 5),
                new ResourceItem("Oxygen", 0, 1000, 1, 6),
                new ResourceItem("Blue_Crystal", 0, 1000, 1, 7),
                new ResourceItem("Red_Crystal", 0, 1000, 1, 8),
                new ResourceItem("Gold", 0, 50, 1, 9),
                new ResourceItem("Cement", 0, 1000, 1, 10),
                new ResourceItem("Metal", 0, 1000, 1, 11),
                new ResourceItem("Lumber", 0, 1000, 1, 12),
                new ResourceItem("Water", 0, 1000, 1, 13),
                new ResourceItem("Food", 0, 1000, 1, 14),
                new ResourceItem("Oxygen", 0, 1000, 1, 15),
                new ResourceItem("Blue_Crystal", 0, 1000, 1, 16),
                new ResourceItem("Red_Crystal", 0, 1000, 1, 17),
                new ResourceItem("Gold", 0, 50, 1, 18)
            );
            modelBuilder.Entity<Building>().HasData(
                new Building("Command Centre", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Guild Hub", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Barracks", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Warroom", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Navigational Unit", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Radar", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Medical Facility", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Research Facility", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Tradepost", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Market", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Silos", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Vaults", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Bunkers", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                },
                new Building("Shield", 1)
                {
                    Id = buildingId++,
                    BaseId = 1
                }
            );

            modelBuilder.Entity<Description>().HasData(
                new Description(DescriptionTypeEnum.Resource, "cement", "Resource used for building and upgrading buildings.", 1),
                new Description(DescriptionTypeEnum.Resource, "metal", "Resource used for building and upgrading buildings, and units..", 2),
                new Description(DescriptionTypeEnum.Resource, "lumber", "Resource used for building and upgrading buildings.", 3),
                new Description(DescriptionTypeEnum.Resource, "water", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 4),
                new Description(DescriptionTypeEnum.Resource, "food", "Resource used to keep units and workers alive.", 5),
                new Description(DescriptionTypeEnum.Resource, "oxygen", "Resource used for building and upgrading buildings.", 6),
                new Description(DescriptionTypeEnum.Resource, "blue_crystal", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 7),
                new Description(DescriptionTypeEnum.Resource, "red_crystal", "Resource used for building and upgrading buildings, and creating and upgrading units, as well as keeping units alive and buildings functional.", 8),
                new Description(DescriptionTypeEnum.Resource, "gold", "Resource rarely found in mines. Used to queue building and unit upgrades", 9),
                new Description(DescriptionTypeEnum.Building, "command centre", "This is your center of communication. Upgrading this building can also unlock new options on other buildings.", 10),
                new Description(DescriptionTypeEnum.Building, "guild hub", "This is where you can create a guild, join a guild, communicate with your guild and access guild-related actions.", 11),
                new Description(DescriptionTypeEnum.Building, "barracks", "This is where you build your army. Build units and assign them to squads.", 12),
                new Description(DescriptionTypeEnum.Building, "warroom", "This is where you manage your army. Send your squads out to attack, move them strategically or assign them to train and get stronger.", 13),
                new Description(DescriptionTypeEnum.Building, "navigational unit", "This building is used to view the area around you.", 14),
                new Description(DescriptionTypeEnum.Building, "radar", "This building picks up enemy attacks and any troop movement to your base.", 15),
                new Description(DescriptionTypeEnum.Building, "medical facility", "This building is used to heal your troops after they get hurt.", 16),
                new Description(DescriptionTypeEnum.Building, "research facility", "This building is used to unlock new units and abilities.", 17),
                new Description(DescriptionTypeEnum.Building, "tradepost", "This building is used to send resources to other players.", 18),
                new Description(DescriptionTypeEnum.Building, "market", "This building is used to trade resources with locals of the new planet.", 19),
                new Description(DescriptionTypeEnum.Building, "silos", "Upgrade these buildings to increase your resource storage capabilities.", 20),
                new Description(DescriptionTypeEnum.Building, "vaults", "These buildings are used to protect your resources from raiders.", 21),
                new Description(DescriptionTypeEnum.Building, "bunkers", "These buildings offer protection to your ranged units when defending.", 22),
                new Description(DescriptionTypeEnum.Building, "shield", "Your shield offers all units and buildings protection when you are being attacked.", 23)
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
