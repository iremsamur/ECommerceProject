using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;

using ECommerce.DataAccessLayer.Repository;
using ECommerce.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ECommerce.DataAccessLayer.EntityFramework
{
    public class EfItemDal : GenericRepository<Item>, IItemDal
    {
       

        private readonly Context _context;

        public EfItemDal(Context context) : base(context)
        {
            _context = context;
        }

        public void ChangeItemAdStatusToActive(int id)
        {

            var item = _context.Items.Find(id);
            item.status = true;

            Update(item);
        }

        public void ChangeItemAdStatusToPassive(int id)
        {
            var item = _context.Items.Find(id);
            item.status = false;

            Update(item);
        }

        public bool GetItemByItemNumber(string itemNumber)
        {
            bool check = false;
            var item = _context.Items.Include(x => x.ItemDetail).Where(x => x.ItemDetail.ItemNo == itemNumber).FirstOrDefault();
            if (item == null)
                check = true;



            return check;
        }

        public int GetItemDetailId(int itemId)
        {
            var itemDetailId = _context.Items.Where(x => x.ItemID == itemId).Select(y => y.ItemDetailID).FirstOrDefault();

            return (int)itemDetailId;
        }

        public int GetItemId(string itemName)
        {
            var itemId = _context.Items.Where(x => x.ItemName == itemName && x.status == true).Select(y => y.ItemID).FirstOrDefault();

            return itemId;
        }

     

        public List<Item> GetItemsBySubCategory(List<SubCategory> subCategories)
        {
            List<Item> items = new List<Item>();
            foreach (var category in subCategories)
            {
                var value = _context.Items.Include(x => x.ItemImage).Include(x => x.SubCategory).Include(x => x.ItemDetail).Where(x => x.SubCategoryID == category.SubCategoryID).FirstOrDefault();
                items.Add(value);

            }


            return items;
        }

        public List<Item> GetItemsBySubCategory(int subCategoryID)
        {
            var values = _context.Items.Include(x => x.ItemImage).Include(x => x.SubCategory).Include(x => x.ItemDetail).Where(x => x.SubCategoryID == subCategoryID).ToList();
            return values;

        }

        public List<Item> GetItemsWithItemDetail()
        {
            var values = _context.Items.Include(x => x.ItemDetail).Include(x => x.SubCategory).ToList();
            return values;
        }

        public List<Item> GetItemWithImage()
        {
            var values = _context.Items.Include(x => x.ItemImage).ToList();

            return values;
        }

        public List<Item> GetItemWithImageAndCategoryAndDetail()
        {
            var values = _context.Items.Include(x => x.ItemImage).Include(x => x.SubCategory).Include(x => x.ItemDetail).ToList();

            return values;
        }

        public Item GetItemWithImageAndCategoryByCategory(int CategoryID)
        {
            var value = _context.Items.Include(x => x.ItemImage).Include(x => x.SubCategory).Include(x => x.ItemDetail).Where(x => x.SubCategoryID == CategoryID).FirstOrDefault();

            return value;
        }

        public ItemDiscountScoresSpModel GetMostDiscountedItemAllDetails(int CategoryID)
        {
            



            string sql = $"SpGetMostDiscountedItemsByCategory {CategoryID}";
            return _context.ItemDiscountScoresSpModels.FromSqlRaw<ItemDiscountScoresSpModel>(sql).AsEnumerable().FirstOrDefault();
        }

        public ItemRatingsSpModel GetMostLikedItemAllDetails(int CategoryID)
        {
          

           
            
            string sql = $"SpGetMostLikedItemsByCategory {CategoryID}";
            return  _context.ItemRatingsSpModels.FromSqlRaw<ItemRatingsSpModel>(sql).AsEnumerable().FirstOrDefault();

        }

        public Item GetSelectedItemAllDetails(int itemID)
        {
            var value = _context.Items.Include(x => x.ItemImage).Include(x => x.SubCategory).ThenInclude(x => x.Category).Include(x => x.ItemDetail).ThenInclude(x => x.Brand).Where(x => x.ItemID == itemID).FirstOrDefault();

            return value;
        }

    }
}
