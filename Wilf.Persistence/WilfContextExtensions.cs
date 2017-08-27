using Wilf.Persistence.Helpers;

namespace Wilf.Persistence
{
    public static class WilfContextExtensions
    {
        public static int SeedDatabase(this WilfContext wilfContext)
        {
            var seasonCount = default(int);

            var dbSeeder = new DatabaseSeeder(wilfContext);

            seasonCount = dbSeeder.SeedSeasonEntries().Result;

            return seasonCount;
        }
    }
}