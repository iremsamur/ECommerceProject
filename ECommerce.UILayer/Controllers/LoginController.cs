using ECommerce.BusinessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using ECommerce.EntityLayer.Concrete.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
	public class LoginController : Controller
	{
        private SignInManager<AppUser> _signInManager;
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        public LoginController(SignInManager<AppUser> signInManager, IUserService userService, IRoleService roleService)
        {
            _signInManager = signInManager;
            _userService = userService;
            _roleService = roleService;
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
                ViewBag.loggedUserId = loggedUserValues.Id.ToString();
                int roleId = _roleService.TGetLoggedUserRoleId(loggedUserValues.Id);
                if (roleId != 0)
                {
                    string roleTitle = _roleService.TGetLoggedUserRoleTitle(roleId);
                    if (roleTitle.Equals(UserType.Customer.ToString()))
                    {
                        TempData["namesurname"] = loggedUserValues.Name + " " + loggedUserValues.Surname;
                        TempData["imageUrl"] = loggedUserValues.ImageUrl;
                        TempData["email"] = loggedUserValues.Email;
                        return RedirectToAction("GetAllItemAds", "ItemAds");

                    }
               
                    else
                    {
                        return RedirectToAction("NotFoundAuthorizeRolePage", "Error");
                    }

                }
                else
                {
                    return RedirectToAction("NotFoundAuthorizeRolePage", "Error");
                }
       
            }
            return View();
        }
        [HttpGet]
        public IActionResult SellerSignIn()
        {
    
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SellerSignIn(AppUser appUser)
        {
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, false, true);
            var checkLoginSituation = false;

            if (result.Succeeded)
            {
                checkLoginSituation = true;

                ViewBag.checkLogging = checkLoginSituation;

                var username = appUser.UserName;

                var loggedUserValues = _userService.TgetLoggedUserID(username);
                //TempData["namesurname"] = loggedUserValues.Name + " " + loggedUserValues.Surname;
                //TempData["imageUrl"] = loggedUserValues.ImageUrl;
                //TempData["email"] = loggedUserValues.Email;
                int roleId = _roleService.TGetLoggedUserRoleId(loggedUserValues.Id);
                if (roleId != 0)
                {
                    string roleTitle = _roleService.TGetLoggedUserRoleTitle(roleId);
                    if (roleTitle.Equals(UserType.IndividualSeller.ToString()))
                    {
                        return RedirectToAction("Index", "IndividualSeller");

                    }
                    else if (roleTitle.Equals(UserType.CompanySeller.ToString()))
                    {
                        return RedirectToAction("Index", "CompanySeller");
                    }
                    else
                    {
                        return RedirectToAction("NotFoundAuthorizeRolePage", "Error");
                    }

                }
                else
                {
                    return RedirectToAction("NotFoundAuthorizeRolePage", "Error");
                }
               
                
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
