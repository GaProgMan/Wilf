using Wilf.Entities;

namespace Wilf.Facade.ViewModels
{
    public class SeasonViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeCount { get; set; }

        public SeasonViewModel(Season dbModel)
        {
            Name = dbModel.Name;
            Description = dbModel.Descritpion;
            SeasonNumber = dbModel.SeasonNumber;
            EpisodeCount = dbModel.Episodes.Count;
        }
    }
}