using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.Repository;
using ECommerce.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.EntityFramework
{
    public class EfItemDal : GenericRepository<Item>, IItemDal
    {
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
    }
}
