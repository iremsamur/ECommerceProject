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
    public class EfItemDetailDal : GenericRepository<ItemDetail>, IItemDetailDal
    {
        public void ChangeItemDetailStatusToActive(int id)
        {

            using (var context = new Context())
            {
                var itemDetail = context.ItemDetails.Find(id);
                itemDetail.status = true;

                Update(itemDetail);

            }
        }

        public void ChangeItemDetailStatusToPassive(int id)
        {
            using (var context = new Context())
            {
                var itemDetail = context.ItemDetails.Find(id);
                itemDetail.status = false;

                Update(itemDetail);

            }
        }

        public int GetItemDetailId(string itemNumber)
        {
            using (var context = new Context())
            {
                var itemDetailId = context.ItemDetails.Where(x => x.ItemNo == itemNumber).Select(y => y.ItemDetailID).FirstOrDefault();

                return itemDetailId;
            }
        }
    }
}
