using System.Collections.Generic;

namespace Wilf.Entities
{
    /// <summary>
    /// Represents a Season of a TV show.
    /// </summary>
    /// <remarks>
    /// <see cref="SeasonId"/> is the Primary Key
    /// <see cref="Episodes"/> is the collection of episodes which make up this season
    /// </remarks>
    public class Season : BaseWilfEntity, ICommonProperties
    {
        public int SeasonId { get; set; }
        public int SeasonNumber { get; set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
        
        public ICollection<Episode> Episodes { get; set; }
    }
}