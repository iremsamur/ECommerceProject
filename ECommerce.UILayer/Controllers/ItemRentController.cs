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
        [HttpGet]
        public IActionResult ChatWithItemOwnerForHiring(int id)
		{
			var username = User.Identity.Name;

            var loggedUserValues = _userService.TgetLoggedUserID(username);
         
            ViewBag.loggedUserImage = loggedUserValues.ImageUrl;
            //ViewBag.SenderMessageUser = loggedUserValues.Name+" "+loggedUserValues.Surname;
            ViewBag.SenderMessageUser = loggedUserValues.Id;
			ViewBag.ItemId = id;

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
