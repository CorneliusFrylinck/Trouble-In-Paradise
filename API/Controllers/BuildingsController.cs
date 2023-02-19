using API.DTOs;
using API.Infrastructure.Core;
using API.Infrastructure.Repositories;
using API.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {
        private readonly IBuildingsRepository buildingsRepository;

        public BuildingsController(IBuildingsRepository buildingsRepository)
        {
            this.buildingsRepository = buildingsRepository;
        }

        [HttpGet("[action]/{baseId}/{name}")]
        public async Task<ResourceBuildingResponseDto?> GetResourceBuildings(int baseId, string name)
        {
            return await buildingsRepository.GetResourceBuilding(baseId, name);
        }

        [HttpPost("[action]/{buildingId}")]
        public async Task<Result> PostUpgradeResourceBuilding(int buildingId)
        {
            return await buildingsRepository.PostUpgradeResourceBuilding(buildingId);
        }
    }
}
