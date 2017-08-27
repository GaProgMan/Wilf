using System;
using Wilf.Entities;
using Wilf.Persistence;

namespace Wilf.DAL
{
    public class SeasonService : ISeasonService
    {
        private readonly WilfContext _wilfContext;

        public SeasonService(WilfContext wilfContext)
        {
            _wilfContext = wilfContext;
        }

        public Season GetOrCreate(int? id)
        {
            var season = _wilfContext.Seasons.Find(id);
            return season ?? new Season();
        }
    }
}