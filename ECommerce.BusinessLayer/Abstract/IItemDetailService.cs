using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IItemDetailService : IGenericService<ItemDetail>
    {
        public int TGetItemDetailId(string itemNumber);
        public void TChangeItemDetailStatusToActive(int id);

        public void TChangeItemDetailStatusToPassive(int id);
    }
}
