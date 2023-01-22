using ECommerce.BusinessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ECommerce.UILayer.ViewComponents.MostLikedItemsPage
{
	public class _MostLikedItemsPage : ViewComponent
	{
		private readonly IItemService _itemService;
        private readonly ISubCategoryService _subCategoryService;

        public _MostLikedItemsPage(IItemService itemService, ISubCategoryService subCategoryService)
        {
            _itemService = itemService;
            _subCategoryService = subCategoryService;
        }

        public IViewComponentResult Invoke()
		{
            Random rnd = new Random();
            var count = _subCategoryService.TGetCountOfSubCategories();
            int randomCategoryID = 0;
            List<ItemRatingsSpModel> items = new List<ItemRatingsSpModel>();
            List<int> randomCategoryIDList = new List<int>();
            var values2 = _itemService.TGetMostLikedItemAllDetails(4);
            for (int j = 1;j <= 2;j++)
            {
                randomCategoryID = rnd.Next(1, 3);//veritabanı verileri kategoriye id'ye göre değiştiriliyor. dinamik yapılacak

                if (!randomCategoryIDList.Contains(randomCategoryID))
                    randomCategoryIDList.Add(randomCategoryID);
                else
                {
                    while (randomCategoryIDList.Contains(randomCategoryID))
                    {
                        randomCategoryID = rnd.Next(1, 3);//veritabanı verileri kategoriye id'ye göre değiştiriliyor. dinamik yapılacak
                    }
                    randomCategoryIDList.Add(randomCategoryID);
                }
            }
            for (int i = 0;i < randomCategoryIDList.Count;i++)
            {
                var values = _itemService.TGetMostLikedItemAllDetails(randomCategoryIDList[i]);
                items.Add(values);

            }


            
            return View(items);
         
		}
	}
}
