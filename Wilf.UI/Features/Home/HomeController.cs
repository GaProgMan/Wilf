using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Wilf.DAL;
using Wilf.Facade;
using Wilf.Facade.ControllerFacades;
using Wilf.UI.Models;

namespace Wilf.UI.Features.Home
{
    public class HomeController : Controller
    {
        private readonly IHomeFacade _homeFacade;
        public HomeController(IHomeFacade homeFacade)
        {
            _homeFacade = homeFacade;
        }

        public IActionResult Index()
        {
            var seasons = _homeFacade.GetAllSeasons();
            return View(seasons);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}