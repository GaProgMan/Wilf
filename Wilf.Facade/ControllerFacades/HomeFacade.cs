using System.Collections.Generic;
using System.Linq;
using Wilf.DAL;
using Wilf.Facade.ViewModels;

namespace Wilf.Facade.ControllerFacades
{
    public class HomeFacade : IHomeFacade
    {
        private readonly ISeasonService _seasonService;

        public HomeFacade(ISeasonService seasonService)
        {
            _seasonService = seasonService;
        }


        public SeasonViewModel GetSeason(int? id)
        {
            var dbSeason = _seasonService.GetOrCreate(id);
            return new SeasonViewModel(dbSeason);
        }

        public IEnumerable<SeasonViewModel> GetAllSeasons()
        {
            var dbSeasons = _seasonService.GetAllSeasons();
            return dbSeasons.Select(dbS => new SeasonViewModel(dbS));
        }
    }
}