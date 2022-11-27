using ECommerce.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UILayer.ViewComponents.AllCategories
{
	public class _AllCategories : ViewComponent
	{
        private readonly ICategoryService _categoryService;

        public _AllCategories(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.TGetList();
            return View(categories);
        }
    }
}
