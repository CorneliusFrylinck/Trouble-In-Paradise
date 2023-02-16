namespace API.Infrastructure.Repositories
{
    public interface IEventsRepository
    {
        /// <summary>
        /// Function to update a base's resource store.
        /// TODO: Check for potential refactors.
        /// </summary>
        /// <param name="baseId"></param>
        /// <returns>True if the update was successful.</returns>
        /// <returns>False if something went wrong.</returns>
        Task<bool> UpdateResourceStoreEventAsync(int baseId);
    }
}