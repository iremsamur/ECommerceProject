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
    public class ItemDetailManager : IItemDetailService
    {
        private IItemDetailDal _itemDetailDal;

        public ItemDetailManager(IItemDetailDal itemDetailDal)
        {
            _itemDetailDal = itemDetailDal;
        }

        public void TDelete(ItemDetail t)
        {
            throw new NotImplementedException();
        }

        public ItemDetail TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int TGetItemDetailId(string itemNumber)
        {
            return _itemDetailDal.GetItemDetailId(itemNumber);
        }

        public List<ItemDetail> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(ItemDetail t)
        {
            _itemDetailDal.Insert(t);
        }

        public void TUpdate(ItemDetail t)
        {
            throw new NotImplementedException();
        }
    }
}
