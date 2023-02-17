using ECommerce.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.ViewComponents.OtherItemAdsBySubCategories
{
	public class _OtherItemAdsBySubCategories : ViewComponent
	{
        private readonly IItemService _itemService;
        private readonly ISubCategoryService _subCategoryService;

        public _OtherItemAdsBySubCategories(IItemService itemService, ISubCategoryService subCategoryService)
        {
            _itemService = itemService;
            _subCategoryService = subCategoryService;
        }
        public IViewComponentResult Invoke()
        {
            var items = _itemService.TGetItemsBySubCategory(2);
            return View(items);
        }

    }
}
