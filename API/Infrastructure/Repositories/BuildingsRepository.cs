using API.Domain;
using API.DTOs;
using API.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace API.Infrastructure.Repositories
{
    public class BuildingsRepository : IBuildingsRepository
    {
        private readonly BetaContext betaContext;

        public BuildingsRepository(BetaContext betaContext)
        {
            this.betaContext = betaContext;
        }

        public async Task<ResourceBuildingResponseDto?> GetResourceBuilding(int baseId, string resourceName)
        {
            List<ResourceBuildingDto> resourceBuildings = new List<ResourceBuildingDto>();
            var buildings = await betaContext.ResourceItems.Where(rb => rb.BaseId == baseId && rb.Name.ToLower() == resourceName.ToLower()).ToListAsync();

            buildings.ForEach(async (b) =>
            {
                int level = b.Level;
                var upgrade = await betaContext.UpgradeDetails.Where(ud => ud.UpgradeTarget == GetTarget(b.Name)).FirstOrDefaultAsync();
                var description = await betaContext.Descriptions.Where(d => d.Name.ToLower() == b.Name.ToLower()).FirstOrDefaultAsync();

                var resourceBuildingDto = new ResourceBuildingDto()
                {
                    BuildingReference = GetBuildingReference(b.Name),
                    Level = level,
                    Production = b.ProductionSpeed,
                    Description = description!.Value,
                    UpgradeDetails = GetUpgradeDetails(upgrade!, level)
                };
                resourceBuildings.Add(resourceBuildingDto);
            });

            return new ResourceBuildingResponseDto()
            {
                ResourceBuildings = resourceBuildings,
            };
        }

        private UpgradeDetail GetUpgradeDetails(UpgradeDetail upgrade, int level)
        {
            double multiplyer = upgrade.LevelCostMultiplier;
            upgrade.Blue_CrystalCost = GetUpdatedCost(upgrade.Blue_CrystalCost, level, multiplyer);
            upgrade.Red_CrystalCost = GetUpdatedCost(upgrade.Red_CrystalCost, level, multiplyer);
            upgrade.MetalCost = GetUpdatedCost(upgrade.MetalCost, level, multiplyer);
            upgrade.WaterCost = GetUpdatedCost(upgrade.WaterCost, level, multiplyer);
            upgrade.FoodCost = GetUpdatedCost(upgrade.FoodCost, level, multiplyer);
            upgrade.LumberCost = GetUpdatedCost(upgrade.LumberCost, level, multiplyer);
            upgrade.CementCost = GetUpdatedCost(upgrade.CementCost, level, multiplyer);
            upgrade.GoldCost = GetUpdatedCost(upgrade.GoldCost, level, multiplyer);
            upgrade.OxygenCost = GetUpdatedCost(upgrade.OxygenCost, level, multiplyer);
            return upgrade;
        }

        private double GetUpdatedCost(double baseValue, int level, double multiplier)
        {
            return baseValue + ((level-1) * ((500 * multiplier * level) + (baseValue * multiplier * level)));
        }

        private string GetBuildingReference(string buildingName)
        {
            switch (buildingName)
            {
                case "Metal": return "Mine";
                case "Cement": return "Kiln";
                case "Lumber": return "Sawmill";
                case "Water": return "Pump";
                case "Food": return "Farm";
                case "Oxygen": return "Pump";
                case "Blue_Crystal": return "Mine";
                case "Red_Crystal": return "Mine";
                case "Gold": return "Mine";
                default: return "Mine";
            }
        }

        private UpgradeTarget GetTarget(string buildingName)
        {
            switch (buildingName)
            {
                case "Metal": return UpgradeTarget.Metal;
                case "Cement": return UpgradeTarget.Cement;
                case "Lumber": return UpgradeTarget.Lumber;
                case "Water": return UpgradeTarget.Water;
                case "Food": return UpgradeTarget.Food;
                case "Oxygen": return UpgradeTarget.Oxygen;
                case "Blue_Crystal": return UpgradeTarget.Blue_Crystal;
                case "Red_Crystal": return UpgradeTarget.Red_Crystal;
                case "Gold": return UpgradeTarget.Gold;
                default: return UpgradeTarget.Metal;
            }
        }
    }
}
