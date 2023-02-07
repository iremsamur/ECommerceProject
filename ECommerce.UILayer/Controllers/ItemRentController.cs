using ECommerce.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.Controllers
{
	public class ItemRentController : Controller
	{
		private readonly IUserService _userService;

		public ItemRentController(IUserService userService)
		{
			_userService = userService;
		}

		public IActionResult ChatWithItemOwnerForHiring()
		{
			var username = User.Identity.Name;

            var loggedUserValues = _userService.TgetLoggedUserID(username);
			//ViewBag.SenderMessageUser = loggedUserValues.Name+" "+loggedUserValues.Surname;
			ViewBag.SenderMessageUser = loggedUserValues.Id;
            return View();
		}
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
