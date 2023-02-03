using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Repository;
using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.EntityFramework
{
    public class EfItemOwnerDal : GenericRepository<ItemOwner>, IItemOwnerDal
    {
    }
}
