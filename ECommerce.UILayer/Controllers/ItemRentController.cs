using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.Controllers
{
	public class ItemRentController : Controller
	{
		public IActionResult GetContactInformationItemOwner()
		{
			return View();
		}
        public IActionResult SendMessageToItemOwner()
        {
            return View();
        }
    }
}
