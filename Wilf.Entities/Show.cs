using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Wilf.Entities
{
    /// <summary>
    /// Represents a TV Show.
    /// </summary>
    /// <remarks>
    /// <see cref="ShowId"/> is the Primary Key
    /// <see cref="Seasons"/> is the collection of Seasons which make up this Show
    /// </remarks>
    public class Show : BaseWilfEntity, ICommonProperties
    {
        public int ShowId { get; set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
        
        public ICollection<Season> Seasons { get; set; } = new Collection<Season>();
    }
}