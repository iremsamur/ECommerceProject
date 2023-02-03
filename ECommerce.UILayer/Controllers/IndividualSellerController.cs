using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.Concrete;

using ECommerce.DTOLayer.ItemDetailDTO;
using ECommerce.DTOLayer.ItemDTOs;
using ECommerce.DTOLayer.ItemOwnerDTOs;
using ECommerce.DTOLayer.MindListDTOs;
using ECommerce.EntityLayer.Concrete;
using ECommerce.EntityLayer.Concrete.Enum;
using ECommerce.UILayer.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
	public class IndividualSellerController : Controller
	{
        private readonly IBrandService _brandService;
        private readonly ISubCategoryService _subCategoryService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IItemService _itemService;
        private readonly IItemOwnerService _itemOwnerService;


        public IndividualSellerController(ISubCategoryService subCategoryService, IMapper mapper, IBrandService brandService, IUserService userService, IItemService itemService, IItemOwnerService itemOwnerService)
        {
            _subCategoryService = subCategoryService;
            _mapper = mapper;
            _brandService = brandService;
            _userService = userService;
            _itemService = itemService;
            _itemOwnerService = itemOwnerService;
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
        public async Task<IActionResult> CreateNewItemAds(CreateNewItemAdsViewModel createNewItemViewModel)
        {


            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);
            CreateItemDTO createItemDTO = new CreateItemDTO();
            if (createNewItemViewModel.ItemShowcaseImage != null)
            {
                var extension = Path.GetExtension(createNewItemViewModel.ItemShowcaseImage.FileName);
              
                var newImageName = Guid.NewGuid() + extension;//Yüklenen resmin yeni ismi
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ItemImages/", newImageName);
                var stream = new FileStream(location, FileMode.Create);//Dosya oluştur.
                createNewItemViewModel.ItemShowcaseImage.CopyTo(stream);//Yüklenen dosyayı Dosya akışına kopyala.
                createItemDTO.ItemShowcaseImage= "/ItemImages/"+newImageName;
            }
            if (createNewItemViewModel.ItemSubShowcaseImage != null)
            {
                var extension = Path.GetExtension(createNewItemViewModel.ItemSubShowcaseImage.FileName);

                var newImageName = Guid.NewGuid() + extension;//Yüklenen resmin yeni ismi
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ItemImages/", newImageName);
                var stream = new FileStream(location, FileMode.Create);//Dosya oluştur.
                createNewItemViewModel.ItemSubShowcaseImage.CopyTo(stream);//Yüklenen dosyayı Dosya akışına kopyala.
                createItemDTO.ItemSubShowcaseImage = "/ItemImages/" + newImageName;
            }
            createItemDTO.ItemName = createNewItemViewModel.ItemName;
            createItemDTO.SubCategoryID = createNewItemViewModel.SubCategoryID;
            var values = _mapper.Map<Item>(createItemDTO);
            _itemService.TInsert(values);


            var value = _itemService.TGetItemId(createItemDTO.ItemName);
            ItemOwnerDTO itemOwnerDTO = new ItemOwnerDTO();
            itemOwnerDTO.OwnerId = loggedUserValues.Id;
            itemOwnerDTO.ItemAdId = value;
            _itemOwnerService.TInsert(_mapper.Map<ItemOwner>(itemOwnerDTO));
           // await AddItemOwner(itemOwnerDTO);

            return RedirectToAction("Index");


            /*
             *   
              var httpClient = new HttpClient();
              var jsonItem = JsonConvert.SerializeObject(createItemDTO);
              StringContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
              var responseMessage = await httpClient.PostAsync("https://localhost:44362/api/IndividualSeller/CreateItemAds", content);

              if (responseMessage.IsSuccessStatusCode)
              {

                  var value = _itemService.TGetItemId(createItemDTO.ItemName);
                  ItemOwnerDTO itemOwnerDTO = new ItemOwnerDTO();
                  itemOwnerDTO.OwnerId = loggedUserValues.Id;
                  itemOwnerDTO.ItemAdId = value;
                  await AddItemOwner(itemOwnerDTO);

                  return RedirectToAction("Index");
              }
            */
           
        }

        public async Task<bool> AddItemOwner(ItemOwnerDTO itemOwnerDTO)
        {

            var httpClient = new HttpClient();
            var jsonMindList = JsonConvert.SerializeObject(itemOwnerDTO);//ekleyeceğim parametreyi serialize eder.
            StringContent content = new StringContent(jsonMindList, Encoding.UTF8, "application/json");

            var responseMessage = await httpClient.PostAsync("https://localhost:44362/api/ItemOwner/AddItemOwner", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                //eğer başarılı ise
                return true;
            }

            return false;




        }





        [HttpGet]
        public IActionResult AddItemDetails()
        {
            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);

            List<SelectListItem> brandValues = (from x in _brandService.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.BrandTitle,
                                                       Value = x.BrandID.ToString()

                                                   }).ToList();
            //önce userid gelecek itemowner'dan sonrasında bu id'nin itemlarını listeleyecek. Bu item'dan seçim yapıp onun detayını ekleyecek

            ViewBag.brands = brandValues;




            return View();
        }
        //ek işlemi backend operasyonlarının yazılacağı apinin çağırılacağı metod
        [HttpPost]
        public async Task<IActionResult> AddItemDetails(CreateItemDetailDTO createItemDetailDTO)
        {
    
            var httpClient = new HttpClient();
            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);
            createItemDetailDTO.AppUserId = loggedUserValues.Id;
            createItemDetailDTO.ItemNo = GetItemNo();
            bool isAvailableItemNumber = _itemService.TGetItemByItemNumber(createItemDetailDTO.ItemNo);
            if (isAvailableItemNumber == false)
            {
                createItemDetailDTO.ItemNo = GetItemNo();
            }
            createItemDetailDTO.ItemAnnouncementDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            createItemDetailDTO.ItemSellerType = (int)ItemSellerType.Sahibinden;
            createItemDetailDTO.FromWho = "Sahibinden";
        
            var jsonItemDetail = JsonConvert.SerializeObject(createItemDetailDTO);
            StringContent content = new StringContent(jsonItemDetail, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44362/api/IndividualSeller/CreateItemDetailAds", content);
            
            if (responseMessage.IsSuccessStatusCode)
            {
                //eğer başarılı ise
             
                return RedirectToAction("Index");
            }
            return View(createItemDetailDTO);
        }
        public string GetItemNo()
        {
            Random a = new Random();
            List<int> randomList = new List<int>();
            int MyNumber = 0;
            string itemNo = " ";
            MyNumber = a.Next(100, 9999999);
            if (!randomList.Contains(MyNumber))
            {
                randomList.Add(MyNumber);
                itemNo = MyNumber.ToString();
            }
            return itemNo;
                
            

        }



    }
}
