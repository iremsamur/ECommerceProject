using ECommerce.BusinessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.UILayer.ViewComponents.HighlightsPage
{
	public class _HighlightsPage : ViewComponent
	{
        private readonly IItemService _itemService;
        private readonly ISubCategoryService _subCategoryService;

        public _HighlightsPage(IItemService itemService, ISubCategoryService subCategoryService)
        {
            _itemService = itemService;
            _subCategoryService = subCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            Random rnd = new Random();
            var count = _subCategoryService.TGetCountOfSubCategories();
            int randomCategoryID = 0;
            List<Item> items = new List<Item>();
            List<int> randomCategoryIDList = new List<int>();
            for (int j = 1;j <= 2;j++)
            {
                randomCategoryID = rnd.Next(3, 5);

                if (!randomCategoryIDList.Contains(randomCategoryID))
                    randomCategoryIDList.Add(randomCategoryID);
                else
                {
                    while (randomCategoryIDList.Contains(randomCategoryID))
                    {
                        randomCategoryID = rnd.Next(3, 5);
                    }
                    randomCategoryIDList.Add(randomCategoryID);
                }
            }
            for(int i = 0;i < randomCategoryIDList.Count;i++)
            {
                var item = _itemService.TGetItemWithImageAndCategoryByCategory(randomCategoryIDList[i]);
                items.Add(item);
            }





                /*
                 * orjinal
                for (int j = 1;j <=4 ;j++)
                {
                    randomCategoryID = rnd.Next(1, count + 1);
                    var item = _itemService.TGetItemWithImageAndCategoryByCategory(randomCategoryID);
                    items.Add(item);
                //o kategori id'si var mı kontrol eklenecek



                }
                */
                
            
            ViewBag.slide1 = items.ElementAt(0);
            ViewBag.slide2 = items.ElementAt(1);
            ViewBag.slide3 = items.ElementAt(0);
            ViewBag.slide4 = items.ElementAt(1);
            //ViewBag.slide3 = items.ElementAt(2);
            //ViewBag.slide4 = items.ElementAt(3);

            return View();
        }

    }
}
