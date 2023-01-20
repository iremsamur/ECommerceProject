using ECommerce.BusinessLayer.Abstract;
using ECommerce.DTOLayer.ItemDTOs;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
    public class ItemUIController : Controller
    {
        private readonly IItemService _itemService;

        public ItemUIController(IItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult GetItemsInTheShowcaseWithImage()
        {
            //sadece 3 veri gelsin
            List<Item> items = new List<Item>();
            var values = _itemService.TGetItemWithImageAndCategoryAndDetail();
            var count = values.Count();
            for(int i = 0;i < count;i++)
            {
                
                if (i < 3)
                {
                    items.Add(values[i]);

                }
                else
                {
                    break;
                }
            }

            return View(items);
        }
        public IActionResult GetItemDetails()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetSelectedItemDetails(int id)
        {
            //bana güncellenecek kullanıcı verilerini getirir.
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44362/api/Item/GetSelectedItemDetail/" + id);//id değerine göre veriyi alıyor
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonItem = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ItemDetailListDTO>(jsonItem);
                return View(values);


            }
            else
            {
                return RedirectToAction("GetAllItemAds", "ItemAds");
            }
        }
    }
}
