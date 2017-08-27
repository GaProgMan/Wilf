using Wilf.Facade.ApiFacades;

namespace Wilf.UI.Api
{
    public class ApiController : BaseApiController
    {
        private readonly IBaseApiFacade _apiFacade;

        public ApiController(IBaseApiFacade apiFacade)
        {
            _apiFacade = apiFacade;
        }

        public string Index()
        {
            return _apiFacade.ApiUseageString();
        }
    }
}