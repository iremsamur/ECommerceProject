using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.ViewComponents.MostLikedItemsPage
{
	public class _MostLikedItemsPage : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
