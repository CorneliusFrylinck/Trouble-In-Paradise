using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Persistence.Extensions
{
    public static class SeedTestUserExtension
    {
        public static ModelBuilder SeedTestUser(this ModelBuilder modelBuilder)
        {
            int generatedId = 1;

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
                new ResourceItem("Red_Crystal", 0, 200, 1, 8),
                new ResourceItem("Gold", 0, 5, 1, 9),
                new ResourceItem("Cement", 0, 1000, 1, 10),
                new ResourceItem("Metal", 0, 1000, 1, 11),
                new ResourceItem("Lumber", 0, 1000, 1, 12),
                new ResourceItem("Water", 0, 1000, 1, 13),
                new ResourceItem("Food", 0, 1000, 1, 14),
                new ResourceItem("Oxygen", 0, 1000, 1, 15),
                new ResourceItem("Blue_Crystal", 0, 1000, 1, 16),
                new ResourceItem("Red_Crystal", 0, 200, 1, 17),
                new ResourceItem("Gold", 0, 5, 1, 18)
            );
            modelBuilder.Entity<Building>().HasData(
                new Building("Command Centre", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Guild Hub", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Barracks", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Warroom", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Navigational Unit", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Radar", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Medical Facility", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Research Facility", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Tradepost", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Market", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Silos", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Vaults", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Bunkers", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                },
                new Building("Shield", 1)
                {
                    Id = generatedId++,
                    BaseId = 1
                }
            );

            return modelBuilder;
        }
    }
}
