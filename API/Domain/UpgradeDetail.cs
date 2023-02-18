namespace API.Domain
{
    public class UpgradeDetail
    {
        public UpgradeDetail(int maxLevel, double levelCostMultiplier, UpgradeTarget upgradeTarget, double metalCost, double cementCost,
            double lumberCost, double waterCost, double foodCost, double oxygenCost, double blue_CrystalCost,
            double red_CrystalCost, double goldCost, int upgradeTimeInSeconds, double productionAfterUpgrade, int id)
        {
            MaxLevel = maxLevel;
            LevelCostMultiplier = levelCostMultiplier;
            UpgradeTarget = upgradeTarget;
            MetalCost = metalCost;
            CementCost = cementCost;
            LumberCost = lumberCost;
            WaterCost = waterCost;
            FoodCost = foodCost;
            OxygenCost = oxygenCost;
            Blue_CrystalCost = blue_CrystalCost;
            Red_CrystalCost = red_CrystalCost;
            GoldCost = goldCost;
            UpgradeTimeInSeconds = upgradeTimeInSeconds;
            ProductionAfterUpgrade = productionAfterUpgrade;
            Id = id;
        }

        public int Id { get; set; }
        public int MaxLevel { get; set; }
        public double LevelCostMultiplier { get; set; }
        public UpgradeTarget UpgradeTarget { get; set; }
        public double MetalCost { get; set; }
        public double CementCost { get; set; }
        public double LumberCost { get; set; }
        public double WaterCost { get; set; }
        public double FoodCost { get; set; }
        public double OxygenCost { get; set; }
        public double Blue_CrystalCost { get; set; }
        public double Red_CrystalCost { get; set; }
        public double GoldCost { get; set; }
        public int UpgradeTimeInSeconds { get; set; }
        public double ProductionAfterUpgrade { get; set; }
    }
}
