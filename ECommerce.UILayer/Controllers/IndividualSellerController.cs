using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.Concrete;
using ECommerce.DTOLayer.ItemDTOs;
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
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
	public class IndividualSellerController : Controller
	{
        private readonly ISubCategoryService _subCategoryService;
        private readonly IMapper _mapper;

        public IndividualSellerController(ISubCategoryService subCategoryService, IMapper mapper)
        {
            _subCategoryService = subCategoryService;
            _mapper = mapper;
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

            var httpClient = new HttpClient();
          
            var jsonItem = JsonConvert.SerializeObject(createItemDTO);
            StringContent content = new StringContent(jsonItem, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44362/api/IndividualSeller/CreateItemAds", content);
       
            if (responseMessage.IsSuccessStatusCode)
            {
                //eğer başarılı ise
                return RedirectToAction("Index");
            }
            return View(createItemDTO);
        }


    }
}
