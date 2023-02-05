using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Abstract
{
    public interface IItemDetailDal : IGenericDal<ItemDetail>
    {
        int GetItemDetailId(string itemNumber);
       
        public void ChangeItemDetailStatusToActive(int id);

        public void ChangeItemDetailStatusToPassive(int id);
    }
}
