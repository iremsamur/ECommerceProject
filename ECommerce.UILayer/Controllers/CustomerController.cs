
using ECommerce.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUserService _userService;
        private readonly INewItemNotificationService _newItemNotificationService;

        public CustomerController(IUserService userService, INewItemNotificationService newItemNotificationService)
        {
            _userService = userService;
            _newItemNotificationService = newItemNotificationService;
        }

        public IActionResult Index()
        {
            var username = User.Identity.Name;

            var loggedUserValues = _userService.TgetLoggedUserID(username);

            ViewBag.loggedUserImage = loggedUserValues.ImageUrl;
            ViewBag.loggedUserFullName = loggedUserValues.Name + " " + loggedUserValues.Surname;
            //ViewBag.SenderMessageUser = loggedUserValues.Name+" "+loggedUserValues.Surname;
            ViewBag.SenderMessageUser = loggedUserValues.Id;
            ViewBag.notificationCount = _newItemNotificationService.TGetNewItemNotification().Count;
            return View();
        }
       
    }
}
