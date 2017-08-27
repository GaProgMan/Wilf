using System.Collections.Generic;
using Wilf.Facade.ViewModels;

namespace Wilf.Facade.ControllerFacades
{
    public interface IHomeFacade
    {
        SeasonViewModel GetSeason(int? id);
        IEnumerable<SeasonViewModel> GetAllSeasons();
    }
}