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
    }
}