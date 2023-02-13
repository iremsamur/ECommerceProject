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
        private readonly Context _context;

        public EfItemDetailDal(Context context) : base(context)
        {
            _context = context;
        }
        public void ChangeItemDetailStatusToActive(int id)
        {

            var itemDetail = _context.ItemDetails.Find(id);
            itemDetail.status = true;

            Update(itemDetail);
        }

        public void ChangeItemDetailStatusToPassive(int id)
        {
            var itemDetail = _context.ItemDetails.Find(id);
            itemDetail.status = false;

            Update(itemDetail);
        }

        public int GetItemDetailId(string itemNumber)
        {
            var itemDetailId = _context.ItemDetails.Where(x => x.ItemNo == itemNumber).Select(y => y.ItemDetailID).FirstOrDefault();

            return itemDetailId;
        }
    }
}
