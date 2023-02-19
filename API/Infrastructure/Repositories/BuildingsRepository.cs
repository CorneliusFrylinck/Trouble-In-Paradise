using API.Domain;
using API.DTOs;
using API.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Http;
using API.Infrastructure.Core;

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

        public async Task<Result> PostUpgradeResourceBuilding(int buildingId)
        {
            // Get building to upgrade
            var building = await betaContext.ResourceItems.Where(b => b.Id == buildingId).FirstOrDefaultAsync();
            if (building == null) return new Result(404, "The building could not be found on this server.");

            // Get the base upgrade to calculate the next upgrade
            var upgrade = await betaContext.UpgradeDetails.Where(ud => ud.UpgradeTarget == GetTarget(building.Name)).FirstOrDefaultAsync();
            if (upgrade == null) return new Result(404, "The building was not found on the upgradeable list.");

            // Get the resource store to verify that the user has enough resources for the upgrade
            var resourceStore = await betaContext.ResourceStores.Where(s => s.BaseId == building.BaseId).FirstOrDefaultAsync();
            if (resourceStore == null) return new Result(404, "The building resource store was not found.");

            // Calculate the prices for the next upgrade
            var nextUpgrade = GetUpgradeDetails(upgrade, building.Level+1);

            // Validate whether the user can afford the upgrade
            if (!CanUpgrade(nextUpgrade, resourceStore)) 
                return new Result(400, "You do not have enough resources to perform this upgrade.");

            // Subtract resources
            // Create update object

            // Indicate success
            return new Result(204, "Upgrade queued!");
        }

        private bool CanUpgrade(UpgradeDetail upgrade, ResourceStore store)
        {
            if (store.Oxygen < upgrade.OxygenCost) return false;
            if (store.Blue_Crystal < upgrade.Blue_CrystalCost) return false;
            if (store.Red_Crystal < upgrade.Red_CrystalCost) return false;
            if (store.Metal < upgrade.MetalCost) return false;
            if (store.Lumber < upgrade.LumberCost) return false;
            if (store.Cement < upgrade.CementCost) return false;
            if (store.Food < upgrade.FoodCost) return false;
            if (store.Gold < upgrade.GoldCost) return false;

            return true;
        }

        private UpgradeDetail GetUpgradeDetails(UpgradeDetail upgrade, int level)
        {
            // Multiplier is used to ensure that some buildings can increase in cost compared to others
            double multiplyer = upgrade.LevelCostMultiplier;
            // Calculate updated costs for all resources
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
