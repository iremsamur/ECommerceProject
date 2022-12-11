using ECommerce.BusinessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
	public class LoginController : Controller
	{
        private SignInManager<AppUser> _signInManager;
        private readonly IUserService _userService;

        public LoginController(SignInManager<AppUser> signInManager, IUserService userService)
        {
            _signInManager = signInManager;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            var checkLoginSituation = false;
            ViewBag.checkLogging = checkLoginSituation;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(AppUser appUser)
        {
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, false, true);
            var checkLoginSituation = false;
          


            if (result.Succeeded)
            {
                checkLoginSituation = true;

                ViewBag.checkLogging = checkLoginSituation;

                var username = appUser.UserName;
                
                var loggedUserValues = _userService.TgetLoggedUserID(username);
                TempData["namesurname"] = loggedUserValues.Name + " " + loggedUserValues.Surname;
                TempData["imageUrl"] = loggedUserValues.ImageUrl;
                TempData["email"] = loggedUserValues.Email;
                return RedirectToAction("GetAllItemAds","ItemAds");
            }
            return View();
        }
        /*
        private SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Index()
		{
			return View();
		}

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(AppUser appUser)
        {
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn");

            }
            return View();


        }
        */




    }
}
