using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IItemDetailOwnerService : IGenericService<ItemDetailOwner>
    {
        public List<ItemDetailOwner> TGetItemDetailOwnerByLoggedUser(int userId);
        public void TChangeItemDetailOwnerStatusToActive(int id);

        public void TChangeItemDetailOwnerStatusToPassive(int id);
    }

}
