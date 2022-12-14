using ECommerce.BusinessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.UILayer.Controllers
{
    public class ItemAdsController : Controller
    {
        private readonly IItemService _itemService;

        public ItemAdsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult GetAllItemAds()
        {
            List<Item> items = new List<Item>();
            var values = _itemService.TGetItemWithImage();
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
