using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.Concrete;
using ECommerce.DataAccessLayer.CQRS.Commands.MindListCommands;
using ECommerce.DTOLayer.CommentDTOs;
using ECommerce.DTOLayer.MindListDTOs;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
    public class MyMindListController : Controller
    {
        private readonly IMindListService _mindListService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public MyMindListController(IMindListService mindListService, IUserService userService, IMapper mapper)
        {
            _mindListService = mindListService;
            _userService = userService;
            _mapper = mapper;
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
            mindListDTO.status = true;

            var availableItems =  _mindListService.TGetMyMindListItemsWithAppUserAndItem(mindListDTO.UserId, mindListDTO.ItemId);
            if (availableItems.Count > 0)
            {
                _mindListService.TChangeMindListStatusToTrue(mindListDTO.ItemId);
                return RedirectToAction("GetMindListCheckoutPage");
            }
            else
            {
                bool checkIsAvailableUser = await GetMindListByItemAndUserID(mindListDTO.UserId, mindListDTO.ItemId);
                if (!checkIsAvailableUser)
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

                }
            }

         
            return RedirectToAction("GetAllItemAds", "ItemAds");




        }

        //checkout için
        [HttpGet]
        public async Task<IActionResult> GetMindListCheckoutPage()
        {
            //Burada aklımdakiler listesinde yer alan tüm ürünler gelecek ve yanlarında satın al kirala butonları olacak tıklanan butona göre uygun sayfaya yönlendirilecekler
            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);
            ViewBag.loggedUserImage = loggedUserValues.ImageUrl;
           
            List<MindListDTO> mindList = await GetMindListByUserID(loggedUserValues.Id);
            ViewBag.itemCount = mindList.Count; 
            return View(mindList);
        }
   
        public async Task<bool> GetMindListByItemAndUserID(int userId, int itemId)
        {
            bool checkIsExistedUser = false;
            //bana güncellenecek kullanıcı verilerini getirir.
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"https://localhost:44362/api/MindList/GetMindList/{userId}/{itemId}");//id değerine göre veriyi alıyor
            
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonItem = await responseMessage.Content.ReadAsStringAsync();
               
                //ilişkili tablodan gelen verilerileride dto'ya da gösterebilmek için bu böyle eklendi

                if (jsonItem != "[]")
                    checkIsExistedUser = true;
            }
            return checkIsExistedUser;

        }
        public async Task<List<MindListDTO>> GetMindListByUserID(int userId)
        {
            
            //bana güncellenecek kullanıcı verilerini getirir.
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync($"https://localhost:44362/api/MindList/GetMyMindListByUserId/{userId}");//id değerine göre veriyi alıyor

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonItem = await responseMessage.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<List<MindListDTO>>(jsonItem);
                //ilişkili tablodan gelen verilerileride dto'ya da gösterebilmek için bu böyle eklendi

                return values;
            }
            return new List<MindListDTO>();

        }

        public IActionResult RemoveItem(int id)
        {

            _mindListService.TChangeMindListStatusToFalse(id);


            return RedirectToAction("GetMindListCheckoutPage");


        }


    }
}
