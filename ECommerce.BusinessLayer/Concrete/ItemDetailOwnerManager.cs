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
    public class ItemDetailOwnerManager : IItemDetailOwnerService
    {
        private IItemDetailOwnerDal _itemDetailOwnerDal;

        public ItemDetailOwnerManager(IItemDetailOwnerDal itemDetailOwnerDal)
        {
            _itemDetailOwnerDal = itemDetailOwnerDal;
        }

        public void TDelete(ItemDetailOwner t)
        {
            throw new NotImplementedException();
        }

        public ItemDetailOwner TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ItemDetailOwner> TGetItemDetailOwnerByLoggedUser(int userId)
        {
            return _itemDetailOwnerDal.GetItemDetailOwnerByLoggedUser(userId);
        }

        public List<ItemDetailOwner> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(ItemDetailOwner t)
        {
            _itemDetailOwnerDal.Insert(t);
        }

        public void TUpdate(ItemDetailOwner t)
        {
            throw new NotImplementedException();
        }
    }
}
