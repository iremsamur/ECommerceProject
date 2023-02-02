using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.Controllers
{
	public class IndividualSellerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
