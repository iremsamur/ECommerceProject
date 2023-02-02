using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult NotFoundAuthorizeRolePage()
        {
            return View();
        }
    }
}
