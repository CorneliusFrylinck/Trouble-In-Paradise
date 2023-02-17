using API.Domain;
using API.DTOs;

namespace API.Infrastructure.Repositories
{
    public interface IBasesRepository
    {
        /// <summary>
        /// Function to get a base by id.
        /// TODO: After players are added, add a function to get base names by player id. Possibility: create Dto that holds the active base, and the names of the other bases.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Base</returns>
        Task<Base?> GetBaseByIdAsync(int id);

        /// <summary>
        /// Function to get a base's resource store by base id.
        /// </summary>
        /// <param name="baseId"></param>
        /// <returns>Resource Store</returns>
        Task<ResourceStore?> GetBaseResourceStoreByBaseIdAsync(int baseId);

        /// <summary>
        /// Function to get a base's resource production rates by base id.
        /// </summary>
        /// <param name="baseId"></param>
        /// <returns>Hourly Resource Production Rate</returns>
        Task<ResourceProductionRequestDto?> GetBaseResourceProductionRatesByBaseIdAsync(int baseId);
    }
}