using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class BetaContext: DbContext
    {
        public BetaContext(DbContextOptions<BetaContext> options) : base(options) { }

        DbSet<Base> bases { get; set; } = null!;
        DbSet<Building> buildings { get; set; } = null!;
        DbSet<ResourceItem> resourceItems { get; set; } = null!;
        DbSet<ResourceStore> resourceStores { get; set; } = null!;
    }
}
