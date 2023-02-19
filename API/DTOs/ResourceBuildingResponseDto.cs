using API.Domain;

namespace API.DTOs
{
    public class ResourceBuildingResponseDto
    {
        public List<ResourceBuildingDto> ResourceBuildings { get; set; }
        public double CapacityUsed { get; set; }
        public double CapacityTotal { get; set; }
        public double ProtectedUsed { get; set; }
        public double ProtectedTotal { get; set; }
    }

    public class ResourceBuildingDto
    {
        public string BuildingReference { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public double Production { get; set; }
        public UpgradeDetail UpgradeDetails { get; set; }
    }
}
