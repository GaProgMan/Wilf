namespace Wilf.Entities
{
    /// <summary>
    /// Represents an Episode of a TV show. 
    /// </summary>
    /// <remarks>
    /// <see cref="EpisodeId"/> is the Primary Key
    /// <see cref="Season"/> is the season this episode is in
    /// </remarks>
    public class Episode : BaseAudit, ICommonProperties
    {
        public int EpisodeId { get; set; }
        public int SeasonId { get; set; }
        public int EpisodeNumber { get; set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
        
        public virtual Season Season { get; set; }
    }
}