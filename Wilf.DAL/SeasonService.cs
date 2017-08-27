using System.Collections.Generic;
using System.Linq;
using Wilf.Entities;
using Wilf.Persistence;

namespace Wilf.DAL
{
    public class SeasonService : BaseWilfService, ISeasonService
    {
        public SeasonService(WilfContext wilfContext) : base(wilfContext)
        {
        }

        public IEnumerable<Season> GetAllSeasons(bool includeNavigationProperties = true)
        {
            return BaseReadOnlyQuery<Season>(includeNavigationProperties);
        }

        public Season GetOrCreate(int? id)
        {
            var season = _wilfContext.Seasons.Find(id);
            return season ?? new Season();
        }
    }
}