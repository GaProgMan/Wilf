using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Wilf.Entities;
using Wilf.Persistence;

namespace Wilf.DAL
{
    public class BaseWilfService : IBaseWilfService
    {
        protected readonly WilfContext _wilfContext;

        public BaseWilfService(WilfContext wilfContext)
        {
            _wilfContext = wilfContext;
        }

        /// <summary>
        /// Used to perform a trackable query on any dbset of entities which extend
        /// the <see cref="IBaseWilfEntity" /> - i.e. any changes made to the context
        /// will be tracked.
        /// </summary>
        /// <param name="includeNavigationProperties">
        /// Indicates whether all navigation properties should be traversed in order
        /// to get all related entities
        /// </param>
        /// <returns>
        /// The set of all entities which match the passed in <see cref="T"/>
        /// with change tracking enabled
        /// </returns>
        public IEnumerable<T> BaseQuery<T>(bool includeNavigationProperties = false)
            where T : BaseWilfEntity, new()
        {
            var query = _wilfContext.Set<T>().AsQueryable();

            if (includeNavigationProperties)
            {
                query = query.IncludeAll<T>();
            }
            return query;
        }

        /// <summary>
        /// Used to perform a read only query on any dbset of entities which extend
        /// the <see cref="IBaseWilfEntity" />.
        /// </summary>
        /// <param name="includeNavigationProperties">
        /// Indicates whether all navigation properties should be traversed in order
        /// to get all related entities
        /// </param>
        /// <returns>
        /// The set of all entities which match the passed in <see cref="T"/>
        /// with change tracking disabled
        /// </returns>
        public IEnumerable<T> BaseReadOnlyQuery<T>(bool includeNavigationProperties = false) where T : BaseWilfEntity, new()
        {
            var query = _wilfContext.Set<T>().AsNoTracking().AsQueryable();

            if (includeNavigationProperties)
            {
                query = query.IncludeAll<T>();
            }
            return query;
        }
    }
}