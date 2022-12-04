using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.Controllers
{
    public class ItemAdsController : Controller
    {
        public IActionResult GetAllItemAds()
        {
            return View();
        }
    }
}
