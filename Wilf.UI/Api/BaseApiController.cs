using Microsoft.AspNetCore.Mvc;

namespace Wilf.UI.Api
{
    public class BaseApiController : Controller
    {
        protected JsonResult ErrorResponse(string message = "Not Found")
        {
            return Json (new {
                Success = false,
                Result = message
            });
        }

        protected JsonResult MessageResult(string message, bool success = true)
        {
            return Json(new {
                Success = success,
                Result = message
            });
        }
    }
}