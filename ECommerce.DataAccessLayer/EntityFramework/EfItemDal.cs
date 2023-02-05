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
        public void ChangeItemAdStatusToActive(int id)
        {

            using (var context = new Context())
            {
                var item = context.Items.Find(id);
                item.status = true;
                
                Update(item);

            }
        }

        public void ChangeItemAdStatusToPassive(int id)
        {
            using (var context = new Context())
            {
                var item = context.Items.Find(id);
                item.status = false;

                Update(item);

            }
        }

        public bool GetItemByItemNumber(string itemNumber)
        {
            bool check = false;
            using (var context = new Context())
            {
                var item = context.Items.Include(x=>x.ItemDetail).Where(x => x.ItemDetail.ItemNo == itemNumber).FirstOrDefault();
                if (item == null)
                    check = true;



                return check;
            }
        }

        public int GetItemDetailId(int itemId)
        {
            using (var context = new Context())
            {
                var itemDetailId = context.Items.Where(x => x.ItemID == itemId).Select(y => y.ItemDetailID).FirstOrDefault();

                return (int)itemDetailId;
            }
        }

        public int GetItemId(string itemName)
        {
            using (var context = new Context())
            {
                var itemId = context.Items.Where(x=>x.ItemName==itemName && x.status == true).Select(y=>y.ItemID).FirstOrDefault();

                return itemId;
            }
        }

     

        public List<Item> GetItemsBySubCategory(List<SubCategory> subCategories)
        {
            List<Item> items = new List<Item>();
            using (var context = new Context())
            {
                foreach(var category in subCategories)
                {
                    var value = context.Items.Include(x => x.ItemImage).Include(x => x.SubCategory).Include(x => x.ItemDetail).Where(x => x.SubCategoryID == category.SubCategoryID).FirstOrDefault();
                    items.Add(value);

                }


                return items;
            }
        }

        public List<Item> GetItemWithImage()
        {
            using (var context = new Context())
            {
                var values = context.Items.Include(x => x.ItemImage).ToList();
                
                return values;
            }
        }

        public List<Item> GetItemWithImageAndCategoryAndDetail()
        {
            using (var context = new Context())
            {
                var values = context.Items.Include(x => x.ItemImage).Include(x=>x.SubCategory).Include(x=>x.ItemDetail).ToList();

                return values;
            }
        }

        public Item GetItemWithImageAndCategoryByCategory(int CategoryID)
        {
            using (var context = new Context())
            {
                var value = context.Items.Include(x => x.ItemImage).Include(x => x.SubCategory).Include(x => x.ItemDetail).Where(x=>x.SubCategoryID==CategoryID).FirstOrDefault();

                return value;
            }
        }

        public ItemDiscountScoresSpModel GetMostDiscountedItemAllDetails(int CategoryID)
        {
            Context context = new Context();



            string sql = $"SpGetMostDiscountedItemsByCategory {CategoryID}";
            return context.ItemDiscountScoresSpModels.FromSqlRaw<ItemDiscountScoresSpModel>(sql).AsEnumerable().FirstOrDefault();
        }

        public ItemRatingsSpModel GetMostLikedItemAllDetails(int CategoryID)
        {
            Context context = new Context();

           
            
            string sql = $"SpGetMostLikedItemsByCategory {CategoryID}";
            return  context.ItemRatingsSpModels.FromSqlRaw<ItemRatingsSpModel>(sql).AsEnumerable().FirstOrDefault();

        }

        public Item GetSelectedItemAllDetails(int itemID)
        {
            using (var context = new Context())
            {
                var value = context.Items.Include(x => x.ItemImage).Include(x => x.SubCategory).ThenInclude(x => x.Category).Include(x => x.ItemDetail).ThenInclude(x=>x.Brand).Where(x => x.ItemID == itemID).FirstOrDefault();

                return value;
            }
        }
    }
}
