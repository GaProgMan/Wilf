using Microsoft.AspNetCore.Mvc;
using Wilf.Facade;

namespace Wilf.UI.Features.Api
{
    public class ApiController : Controller
    {
        private readonly IApiFacade _apiFacade;

        public ApiController(IApiFacade apiFacade)
        {
            _apiFacade = apiFacade;
        }

        public string Index()
        {
            return _apiFacade.ApiUseageString();
        }
    }
}