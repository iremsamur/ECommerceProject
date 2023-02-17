using ECommerce.DataAccessLayer.Concrete;
using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Abstract
{
    public interface IItemDal : IGenericDal<Item>
    {
        List<Item> GetItemWithImage();
        List<Item> GetItemWithImageAndCategoryAndDetail();
        Item GetItemWithImageAndCategoryByCategory(int CategoryID);

        ItemRatingsSpModel GetMostLikedItemAllDetails(int CategoryID);
        ItemDiscountScoresSpModel GetMostDiscountedItemAllDetails(int CategoryID);

        Item GetSelectedItemAllDetails(int itemID);
        List<Item> GetItemsBySubCategory(List<SubCategory> subCategories);

        int GetItemId(string itemName);

       
        bool GetItemByItemNumber(string itemNumber);
        public void ChangeItemAdStatusToActive(int id);

        public void ChangeItemAdStatusToPassive(int id);

        int GetItemDetailId(int itemId);

        List<Item> GetItemsBySubCategory(int subCategoryID);

        List<Item> GetItemsWithItemDetail();

    }
}
