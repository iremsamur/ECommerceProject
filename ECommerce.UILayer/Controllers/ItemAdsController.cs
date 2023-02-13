using ECommerce.BusinessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.UILayer.Controllers
{
    public class ItemAdsController : Controller
    {
        private readonly IItemService _itemService;
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ItemAdsController(IItemService itemService, IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _itemService = itemService;
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult GetAllItemAds()
        {
            //var username = _httpContextAccessor.HttpContext.User.Identity.Name;
            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);
            ViewBag.loggedUserImage = loggedUserValues.ImageUrl;
            //string userId =_httpContextAccessor.HttpContext.User.FindFirst("sub").Value;
            List<Item> items = new List<Item>();
            var values = _itemService.TGetItemWithImageAndCategoryAndDetail();
            var count = values.Count();
            for (int i = 0;i < count;i++)
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

        
    }
}
