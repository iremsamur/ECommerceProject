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

        public void TChangeItemDetailStatusToActive(int id)
        {
            _itemDetailDal.ChangeItemDetailStatusToActive(id);
        }

        public void TChangeItemDetailStatusToPassive(int id)
        {
            _itemDetailDal.ChangeItemDetailStatusToPassive(id);
        }

        public void TDelete(ItemDetail t)
        {
            throw new NotImplementedException();
        }

        public ItemDetail TGetByID(int id)
        {
            return _itemDetailDal.GetByID(id);
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
            _itemDetailDal.Update(t);
        }
    }
}
