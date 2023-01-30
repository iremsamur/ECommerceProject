using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.Concrete;
using ECommerce.DataAccessLayer.CQRS.Commands.MindListCommands;
using ECommerce.DTOLayer.MindListDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
    public class MyMindListController : Controller
    {
        private readonly IMindListService _mindListService;
        private readonly IUserService _userService;

        public MyMindListController(IMindListService mindListService, IUserService userService)
        {
            _mindListService = mindListService;
            _userService = userService;
        }

        //şimdi ekleme işlemi yazalım.
        [HttpGet]
        public IActionResult AddMindList()
        {
            return View();
        }
        //ek işlemi backend operasyonlarının yazılacağı apinin çağırılacağı metod
        [HttpPost]
        public async Task<IActionResult> AddMindList(MindListDTO mindListDTO)
        {
           

            var httpClient = new HttpClient();
            var jsonMindList = JsonConvert.SerializeObject(mindListDTO);//ekleyeceğim parametreyi serialize eder.
            StringContent content = new StringContent(jsonMindList, Encoding.UTF8, "application/json");

            var responseMessage = await httpClient.PostAsync("https://localhost:44362/api/MindList/AddMindList", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                //eğer başarılı ise
                return RedirectToAction("GetMindListCheckoutPage");
            }
            return View(mindListDTO);
        }

        //checkout için
        [HttpGet]
        public IActionResult GetMindListCheckoutPage()
        {
            //Burada aklımdakiler listesinde yer alan tüm ürünler gelecek ve yanlarında satın al kirala butonları olacak tıklanan butona göre uygun sayfaya yönlendirilecekler
            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);
            ViewBag.loggedUserImage = loggedUserValues.ImageUrl;
            return View();
        }

    }
}
