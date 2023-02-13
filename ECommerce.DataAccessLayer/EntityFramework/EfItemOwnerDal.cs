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
    public class EfItemOwnerDal : GenericRepository<ItemOwner>, IItemOwnerDal
    {
        private readonly Context _context;

        public EfItemOwnerDal(Context context) : base(context)
        {
            _context = context;
        }
        public List<ItemOwner> GetItemOwnerByLoggedUser(int userId)
        {
            var values = _context.ItemOwners
                   .Include(x => x.OwnerUser).Include(x => x.ItemAd).ThenInclude(x => x.ItemDetail).Where(x => x.OwnerId == userId).ToList();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

            return values;
        }
        public void ChangeItemOwnerStatusToActive(int id)
        {

            var itemOwner = _context.ItemOwners.Include(x => x.ItemAd).Where(x => x.ItemAdId == id).FirstOrDefault();
            itemOwner.status = true;

            Update(itemOwner);
        }

        public void ChangeItemOwnerStatusToPassive(int id)
        {
            var itemOwner = _context.ItemOwners.Include(x => x.ItemAd).Where(x => x.ItemAdId == id).FirstOrDefault();
            itemOwner.status = false;

            Update(itemOwner);
        }

        public int GetOwnerByItemId(int id)
        {
            var itemOwnerId = _context.ItemOwners.Include(x => x.ItemAd).Include(x => x.OwnerUser).Where(x => x.ItemAdId == id).Select(y => y.OwnerId).FirstOrDefault();


            return itemOwnerId;
        }
    }
}
