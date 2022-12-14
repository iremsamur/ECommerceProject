using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Concrete
{
    public class ItemManager : IItemService
    {
        IItemDal _itemDal;

        public ItemManager(IItemDal itemDal)
        {
            _itemDal = itemDal;
        }

        public List<Item> TGetItemWithImageAndCategoryAndDetail()
        {
            return _itemDal.GetItemWithImageAndCategoryAndDetail();
        }

        public Item TGetItemWithImageAndCategoryByCategory(int CategoryID)
        {
            return _itemDal.GetItemWithImageAndCategoryByCategory(CategoryID);
        }

        public void TDelete(Item t)
        {
            _itemDal.Delete(t);
        }

        public Item TGetByID(int id)
        {
            return _itemDal.GetByID(id);
        }

        public List<Item> TGetItemWithImage()
        {
        
            return _itemDal.GetItemWithImage();
        }

        public List<Item> TGetList()
        {
            return _itemDal.GetList();
        }

        public void TInsert(Item t)
        {
            _itemDal.Insert(t);
        }

        public void TUpdate(Item t)
        {
            _itemDal.Update(t);
        }

        public ItemRatingsSpModel TGetMostLikedItemAllDetails(int CategoryID)
        {
            return _itemDal.GetMostLikedItemAllDetails(CategoryID);
        }

        public ItemDiscountScoresSpModel TGetMostDiscountedItemAllDetails(int CategoryID)
        {
            return _itemDal.GetMostDiscountedItemAllDetails(CategoryID);
        }
    }
}
