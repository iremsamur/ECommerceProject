using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.DTOLayer.CompanySellerDTOs;
using ECommerce.DTOLayer.ItemDTOs;
using ECommerce.DTOLayer.ItemOwnerDTOs;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
    public class CompanySellerController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public CompanySellerController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);
            ViewBag.loggedUserPhoto = loggedUserValues.ImageUrl;
            ViewBag.loggedUserFullName = loggedUserValues.Name + " " + loggedUserValues.Surname;
            var companyInformations = _userService.TGetLoggedUserCompanyInformations(loggedUserValues.Id);
            var values = _mapper.Map<AppUserDTO>(companyInformations);

            return View(values);
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
    }
}
