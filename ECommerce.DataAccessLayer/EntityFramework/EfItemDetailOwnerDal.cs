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
    public class EfItemDetailOwnerDal : GenericRepository<ItemDetailOwner>, IItemDetailOwnerDal
    {
        public List<ItemDetailOwner> GetItemDetailOwnerByLoggedUser(int userId)
        {
            using (var context = new Context())
            {
                var values = context.ItemDetailOwners
                    .Include(x => x.OwnerUser).Include(x => x.ItemAdDetail).Where(x => x.OwnerId == userId).ToList();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

                return values;
            }
        }
    }
}
