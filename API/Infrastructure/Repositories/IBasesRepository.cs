using API.Domain;

namespace API.Infrastructure.Repositories
{
    public interface IBasesRepository
    {
        Task<Base?> GetBaseByIdAsync(int id);
    }
}