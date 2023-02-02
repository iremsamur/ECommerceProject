using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.Controllers
{
    public class CompanySellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
