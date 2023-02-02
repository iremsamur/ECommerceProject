using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.Concrete;
using ECommerce.DTOLayer.ItemDTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
	public class IndividualSellerController : Controller
	{
        private readonly ISubCategoryService _subCategoryService;

        public IndividualSellerController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateNewItemAds()
        {
            List<SelectListItem> categoryValues = (from x in _subCategoryService.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                               
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }
        //ek işlemi backend operasyonlarının yazılacağı apinin çağırılacağı metod
        [HttpPost]
        public async Task<IActionResult> CreateNewItemAds(CreateItemDTO createItemDTO)
        {
            //çalışmıyor bakılacak
            var httpClient = new HttpClient();
          
            var jsonItem = JsonConvert.SerializeObject(createItemDTO);
            StringContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44362/api/IndividualSellerUI/CreateItemAds", content);
       
            if (responseMessage.IsSuccessStatusCode)
            {
                //eğer başarılı ise
                return RedirectToAction("Index");
            }
            return View(createItemDTO);
        }


    }
}
