using API.Domain;

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
    }
}