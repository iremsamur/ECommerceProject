using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
	public class RegisterController : Controller
	{

        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(AppUser appUser)
        {
            var result = await _userManager.CreateAsync(appUser, appUser.PasswordHash);//bu metod yeni bir kullanıcı değeri oluşturacak. Bir kullanıcı ve şifre istiyor
            //await burada beklemeden çalışmasını sağlar.
            bool check = result.Succeeded;
            if (result.Succeeded)
            {
                ViewBag.registerIsSucceeded = true;
                return RedirectToAction("SignIn","Login");
            }


            return View();
        }

  
    }
}
