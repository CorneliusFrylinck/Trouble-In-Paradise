using API.DTOs;
using API.Infrastructure.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Infrastructure.Repositories
{
    public interface IBuildingsRepository
    {
        Task<ResourceBuildingResponseDto?> GetResourceBuilding(int baseId, string resourceName);
        Task<Result> PostUpgradeResourceBuilding(int buildingId);
    }
}