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
    public class ItemOwnerManager : IItemOwnerService
    {
        private readonly IItemOwnerDal _itemOwnerDal;

        public ItemOwnerManager(IItemOwnerDal itemOwnerDal)
        {
            _itemOwnerDal = itemOwnerDal;
        }

        public void TDelete(ItemOwner t)
        {
            throw new NotImplementedException();
        }

        public ItemOwner TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ItemOwner> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(ItemOwner t)
        {
            _itemOwnerDal.Insert(t);
        }

        public void TUpdate(ItemOwner t)
        {
            throw new NotImplementedException();
        }
    }
}
