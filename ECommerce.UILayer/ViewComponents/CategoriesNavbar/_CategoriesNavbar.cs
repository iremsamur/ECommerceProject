using ECommerce.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ECommerce.UILayer.ViewComponents.CategoriesNavbar
{
	public class _CategoriesNavbar : ViewComponent
	{
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;

        

        public _CategoriesNavbar(ICategoryService categoryService, ISubCategoryService subCategoryService)
        {
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _subCategoryService.TGetSubCategoriesByCategoryID(4);
            return View(categories);
        }

    }
}
