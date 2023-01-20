using ECommerce.DataAccessLayer.Concrete;
using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IItemService : IGenericService<Item>
    {
        List<Item> TGetItemWithImage();
       List<Item> TGetItemWithImageAndCategoryAndDetail();


       Item TGetItemWithImageAndCategoryByCategory(int CategoryID);

        ItemRatingsSpModel TGetMostLikedItemAllDetails(int CategoryID);
        ItemDiscountScoresSpModel TGetMostDiscountedItemAllDetails(int CategoryID);

        Item TGetSelectedItemAllDetails(int itemID);




    }
}
