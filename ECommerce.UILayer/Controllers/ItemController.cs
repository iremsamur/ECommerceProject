using ECommerce.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult GetItemsInTheShowcaseWithImage()
        {
            var values = _itemService.TGetItemWithImage();
            return View(values);
        }
    }
}
