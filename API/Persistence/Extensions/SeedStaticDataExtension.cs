using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Persistence.Extensions
{
    public static class SeedStaticDataExtension
    {
        /// <summary>
        /// Function to seed static data. Staic data is data that should be set only once by the server and will then never change.
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// <returns>ModelBuilder after changes have been added.</returns>
        public static ModelBuilder SeedStaticData(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedResourcceLevelData();
            modelBuilder.SeedDescriptionData();

            return modelBuilder;
        }
    }
}
