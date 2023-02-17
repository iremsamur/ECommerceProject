using ECommerce.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.ViewComponents.OtherItemAds
{
	public class _OtherItemAds : ViewComponent
	{
        private readonly IItemService _itemService;
        private readonly ISubCategoryService _subCategoryService;

        public _OtherItemAds(IItemService itemService, ISubCategoryService subCategoryService)
        {
            _itemService = itemService;
            _subCategoryService = subCategoryService;
        }
        public IViewComponentResult Invoke()
        {
            var items = _itemService.TGetItemsWithItemDetail();
            return View(items);
        }

    }
}
