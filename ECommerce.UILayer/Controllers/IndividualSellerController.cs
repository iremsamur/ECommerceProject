using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.Concrete;
using ECommerce.DataAccessLayer.CQRS.Queries.ItemAds;
using ECommerce.DataAccessLayer.CQRS.Results.ItemAdsResults;
using ECommerce.DTOLayer.ItemDetailDTO;
using ECommerce.DTOLayer.ItemDetailOwnerDTOs;
using ECommerce.DTOLayer.ItemDTOs;
using ECommerce.DTOLayer.ItemOwnerDTOs;
using ECommerce.DTOLayer.MindListDTOs;
using ECommerce.EntityLayer.Concrete;
using ECommerce.EntityLayer.Concrete.Enum;
using ECommerce.UILayer.Models;
using MediatR;
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
        private readonly IItemDetailService _itemDetailService;
        private readonly IItemDetailOwnerService _itemDetailOwnerService;
        private readonly IMediator _mediator;


        public IndividualSellerController(ISubCategoryService subCategoryService, IMapper mapper, IBrandService brandService, IUserService userService, IItemService itemService, IItemOwnerService itemOwnerService, IItemDetailService itemDetailService, IItemDetailOwnerService itemDetailOwnerService, IMediator mediator)
        {
            _subCategoryService = subCategoryService;
            _mapper = mapper;
            _brandService = brandService;
            _userService = userService;
            _itemService = itemService;
            _itemOwnerService = itemOwnerService;
            _itemDetailService = itemDetailService;
            _itemDetailOwnerService = itemDetailOwnerService;
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMyOpenItemAds()
        {
            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);
            //var values2 = await _itemOwnerService.GetMyOpenItemAds(loggedUserValues.Id);
            //var values = await _mediator.Send(new GetMyOpenItemAdsQuery(loggedUserValues.Id));
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44362/api/ItemOwner/GetMyOpenItemAdsByUser/" + loggedUserValues.Id);//id değerine göre veriyi alıyor

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonItem = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetAllMyOpenItemAdsDTO>>(jsonItem);
                return View(values);
            }
            else
            {
                return RedirectToAction("Index");
            }
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
            createItemDTO.status = true;
            createItemDTO.CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            createItemDTO.UpdatedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            var values = _mapper.Map<Item>(createItemDTO);
            if (ModelState.IsValid)
            {
                _itemService.TInsert(values);


                var value = _itemService.TGetItemId(createItemDTO.ItemName);
                ItemOwnerDTO itemOwnerDTO = new ItemOwnerDTO();
                itemOwnerDTO.OwnerId = loggedUserValues.Id;
                itemOwnerDTO.ItemAdId = value;
                itemOwnerDTO.status = true;
                itemOwnerDTO.UpdatedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                itemOwnerDTO.CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                _itemOwnerService.TInsert(_mapper.Map<ItemOwner>(itemOwnerDTO));
           

                return RedirectToAction("GetAllMyOpenItemAds");
            }
            else
            {
                List<SelectListItem> categoryValues = (from x in _subCategoryService.TGetList()
                                                       select new SelectListItem
                                                       {
                                                           Text = x.CategoryName,
                                                           Value = x.CategoryID.ToString()

                                                       }).ToList();
                //bu satır dropdownlistte validasyonda dolayı normalde get içinde geldiği için ama sayfa yeniden yüklenmesi tekrar post içinde de yapılması gerektiği için eklendi
                //SubCategoryID There is no ViewData item of type 'IEnumerable<SelectListItem>' that has the key 'CategoryID' hatası çözüöü
                ViewBag.cv = categoryValues;

                return View(createNewItemViewModel);

            }
         
         
           
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
            createItemDetailDTO.status = true;
            createItemDetailDTO.CreatedDate= DateTime.Parse(DateTime.Now.ToShortDateString()); 
            createItemDetailDTO.UpdatedDate= DateTime.Parse(DateTime.Now.ToShortDateString()); 

            createItemDetailDTO.ItemNewPrice = CalculateNewPrice(createItemDetailDTO.ItemOldPrice, createItemDetailDTO.ItemDiscount);
            var values = _mapper.Map<ItemDetail>(createItemDetailDTO);
            _itemDetailService.TInsert(values);

            var value = _itemDetailService.TGetItemDetailId(createItemDetailDTO.ItemNo);
            ItemDetailOwnerDTO itemDetailOwnerDTO = new ItemDetailOwnerDTO();
            itemDetailOwnerDTO.OwnerId = loggedUserValues.Id;
            itemDetailOwnerDTO.ItemDetailId = value;
            itemDetailOwnerDTO.status = true;
            itemDetailOwnerDTO.CreatedDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            itemDetailOwnerDTO.UpdatedDate= DateTime.Parse(DateTime.Now.ToShortDateString()); 
            var itemDetailOwner = _mapper.Map<ItemDetailOwner>(itemDetailOwnerDTO);
            _itemDetailOwnerService.TInsert(itemDetailOwner);

            return RedirectToAction("Index");

        }
        public double CalculateNewPrice(double oldPrice,double discount)
        {
            return oldPrice * ((100 - discount) / 100);
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

        [HttpGet]
        public IActionResult AddItemDetailToItem()
        {
            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);

            List<SelectListItem> itemValues = (from x in _itemOwnerService.TGetItemOwnerByLoggedUser(loggedUserValues.Id)
                                                select new SelectListItem
                                                {
                                                    Text = x.ItemAd.ItemName,
                                                    Value = x.ItemAdId.ToString()

                                                }).ToList();
            //önce userid gelecek itemowner'dan sonrasında bu id'nin itemlarını listeleyecek. Bu item'dan seçim yapıp onun detayını ekleyecek

            ViewBag.items = itemValues;


            List<SelectListItem> itemDetailValues = (from x in _itemDetailOwnerService.TGetItemDetailOwnerByLoggedUser(loggedUserValues.Id)
                                                     select new SelectListItem
                                                     {
                                                         Text = x.ItemAdDetail.ItemNo,
                                                         Value = x.ItemDetailId.ToString()

                                                     }).ToList();


            ViewBag.itemDetails = itemDetailValues;




            return View();
        }
        //ek işlemi backend operasyonlarının yazılacağı apinin çağırılacağı metod
        [HttpPost]
        public async Task<IActionResult> AddItemDetailToItem(UpdateItemDTO updateItemDTO)
        {
            var values = _itemService.TGetByID(updateItemDTO.ItemID);
            values.ItemDetailID = updateItemDTO.ItemDetailID;
            values.UpdatedDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            _itemService.TUpdate(values);
            return RedirectToAction("Index");
            

        }







    }
}
