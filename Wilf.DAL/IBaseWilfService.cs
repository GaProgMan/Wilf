using System.Collections.Generic;
using Wilf.Entities;

namespace Wilf.DAL
{
    public interface IBaseWilfService
    {
        IEnumerable<T> BaseQuery<T>(bool includeNavigationProperties = false)
            where T : BaseWilfEntity, new();

        IEnumerable<T> BaseReadOnlyQuery<T>(bool includeNavigationProperties = false)
            where T : BaseWilfEntity, new();
    }
}