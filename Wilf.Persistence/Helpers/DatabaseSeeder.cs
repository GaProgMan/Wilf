using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Wilf.Entities;

namespace Wilf.Persistence.Helpers
{
    public class DatabaseSeeder
    {
        private readonly IWilfContext _wilfContext;

        public DatabaseSeeder(IWilfContext wilfContext)
        {
            _wilfContext = wilfContext;
        }

        public async Task<int> SeedSeasonEntries()
        {
            _wilfContext.Seasons.Add(
                new Season
                {
                    Name = "Mash Season 1",
                    SeasonNumber = 1,
                    Descritpion = "The first season of Mash",
                    Episodes = new Collection<Episode>()
                });

            return await _wilfContext.SaveChangesAsync();
        }
    }
}