using System.Collections.Generic;
using Wilf.Entities;

namespace Wilf.DAL
{
    public interface ISeasonService
    {
        /// <summary>
        /// Used to get or create a <see cref="Wilf.Entities.Season"/> entity
        /// </summary>
        /// <param name="id">The ID of the Season entity</param>
        /// <remarks>If the <see param="id"/> parameter is null, a new
        /// instance of a <see cref="Wilf.Entities.Season"/> entity will be returned</remarks>
        /// <returns>An instance of a <see cref="Wilf.Entities.Season"/> entity</returns>
        Season GetOrCreate(int? id);

        /// <summary>
        /// Used to get a list of all <see cref="Season"/> entities in
        /// the database (uses IQueryable and is lazy-loaded)
        /// </summary>
        /// <param name="includeNavigationProperties">
        /// Whether we should include all navigation properties or not
        /// </param>
        /// <returns>An IEnumerable of all <see cref="Season"/> entities</returns>
        IEnumerable<Season> GetAllSeasons(bool includeNavigationProperties = true);
    }
}