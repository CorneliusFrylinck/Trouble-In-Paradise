using API.Data;
using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Repositories
{
    /// <summary>
    /// Repository used to handle the database communication.
    /// 
    /// NOTE: once multiple databases get used this is where it will be managed.
    /// NOTE: interface is used to keep me honest, it keeps a nice view of the available that's easy to check and judge without having to look for the code between the functions.
    /// </summary>
    public class BasesRepository: IBasesRepository
    {
        private BetaContext _betaContext { get; }

        public BasesRepository(BetaContext betaContext)
        {
            _betaContext = betaContext;
        }

        /// <summary>
        /// Function to get a base by id.
        /// TODO: After players are added, add a function to get base names by player id. Possibility: create Dto that holds the active base, and the names of the other bases.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Base</returns>
        public async Task<Base?> GetBaseByIdAsync(int id)
        {
            return await _betaContext.Bases.Where(b => b.Id == id).FirstOrDefaultAsync();
        }
    }
}
