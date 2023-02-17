using API.Domain;
using API.DTOs;
using API.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace API.Controllers
{
    /// <summary>
    /// Controller to receive base-related data.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BasesController : ControllerBase
    {
        private readonly IBasesRepository basesRepository;

        public BasesController(IBasesRepository basesRepository)
        {
            this.basesRepository = basesRepository;
        }

        /// <summary>
        /// Function to get a base's details by base id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Base>> GetBaseAsync(int id)
        {
            var response = await basesRepository.GetBaseByIdAsync(id);

            if (response == null) return NotFound();

            return Ok(response);
        }

        /// <summary>
        /// Function to get a base's details by base id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("resources/{baseId}")]
        public async Task<ActionResult<ResourceStore>> GetBaseResourcesAsync(int baseId)
        {
            var response = await basesRepository.GetBaseResourceStoreByBaseIdAsync(baseId);

            if (response == null) return NotFound();

            return Ok(response);
        }

        /// <summary>
        /// Function to get a base's details by base id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("resources/production/{baseId}")]
        public async Task<ActionResult<ResourceProductionRequestDto>> GetResouceProductionRateAsync(int baseId)
        {
            var response = await basesRepository.GetBaseResourceProductionRatesByBaseIdAsync(baseId);

            if (response == null) return NotFound();

            return Ok(response);
        }
    }
}
