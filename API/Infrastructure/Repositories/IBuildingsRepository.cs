using API.DTOs;

namespace API.Infrastructure.Repositories
{
    public interface IBuildingsRepository
    {
        Task<ResourceBuildingResponseDto?> GetResourceBuilding(int baseId, string resourceName);
    }
}