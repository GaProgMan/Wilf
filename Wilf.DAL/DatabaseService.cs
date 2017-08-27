using Wilf.Persistence;

namespace Wilf.DAL
{
    public class DatabaseService : IDatabaseService
    {
        private readonly WilfContext _wilfContext;

        public DatabaseService(WilfContext wilfContext)
        {
            _wilfContext = wilfContext;
        }

        public bool ClearDatabase()
        {
            var cleared = _wilfContext.Database.EnsureDeleted();
            var created = _wilfContext.Database.EnsureCreated();
            var entitiesadded = _wilfContext.SaveChangesAsync(true).Result;

            return (cleared && created && entitiesadded == 0);
        }

        public int SeedDatabase()
        {
            return _wilfContext.SeedDatabase();
        }
    }
}