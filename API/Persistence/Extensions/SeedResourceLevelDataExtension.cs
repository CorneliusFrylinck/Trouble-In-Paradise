using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Persistence.Extensions
{
    public static class SeedResourceLevelDataExtension
    {
        public static ModelBuilder SeedResourcceLevelData(this ModelBuilder modelBuilder)
        {
            int generatedId = 1;

            modelBuilder.Entity<UpgradeDetail>().HasData(
                new UpgradeDetail(40, 1, UpgradeTarget.Blue_Crystal, 700, 400, 320, 800, 670, 550, 1000, 140, 0, 10, 1000, generatedId++),
                new UpgradeDetail(40, 1, UpgradeTarget.Red_Crystal, 900, 600, 590, 910, 530, 580, 1800, 200, 0, 20, 300, generatedId++),
                new UpgradeDetail(40, 1, UpgradeTarget.Metal, 520, 860, 300, 600, 550, 500, 1200, 170, 0, 10, 1000, generatedId++),
                new UpgradeDetail(40, 1, UpgradeTarget.Cement, 930, 350, 350, 550, 600, 540, 1250, 140, 0, 10, 1000, generatedId++),
                new UpgradeDetail(40, 1, UpgradeTarget.Food, 430, 400, 360, 900, 270, 790, 1100, 100, 0, 10, 1000, generatedId++),
                new UpgradeDetail(40, 1, UpgradeTarget.Lumber, 550, 440, 480, 450, 890, 760, 1150, 200, 0, 10, 1000, generatedId++),
                new UpgradeDetail(40, 1, UpgradeTarget.Water, 660, 490, 560, 390, 620, 650, 1300, 160, 0, 10, 1000, generatedId++),
                new UpgradeDetail(40, 1, UpgradeTarget.Oxygen, 780, 520, 530, 640, 400, 300, 1400, 110, 0, 10, 1000, generatedId++)
            );

            return modelBuilder;
        }
    }
}
