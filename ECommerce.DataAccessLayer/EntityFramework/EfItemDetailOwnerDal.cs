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
        private readonly Context _context;

        public EfItemDetailOwnerDal(Context context) : base(context)
        {
            _context = context;
        }
        public List<ItemDetailOwner> GetItemDetailOwnerByLoggedUser(int userId)
        {
            var values = _context.ItemDetailOwners
                   .Include(x => x.OwnerUser).Include(x => x.ItemAdDetail).Where(x => x.OwnerId == userId).ToList();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

            return values;
        }
        public void ChangeItemDetailOwnerStatusToActive(int id)
        {

            var itemDetailOwner = _context.ItemDetailOwners.Include(x => x.ItemAdDetail).Where(x => x.ItemDetailId == id).FirstOrDefault();
            itemDetailOwner.status = true;

            Update(itemDetailOwner);
        }

        public void ChangeItemDetailOwnerStatusToPassive(int id)
        {
            var itemDetailOwner = _context.ItemDetailOwners.Include(x => x.ItemAdDetail).Where(x => x.ItemDetailId == id).FirstOrDefault();
            itemDetailOwner.status = false;

            Update(itemDetailOwner);

        }
    }
}
