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
    public class EfMindListDal : GenericRepository<MindList>, IMindListDal
    {
        private readonly Context _context;

        public EfMindListDal(Context context) : base(context)
        {
            _context = context;
        }

        public void ChangeMindListStatusToFalse(int itemId)
        {
            var item = _context.MindLists.Where(x=>x.ItemId==itemId).FirstOrDefault();
            item.status = false;

            Update(item);
        }

        public void ChangeMindListStatusToTrue(int itemId)
        {
            var item = _context.MindLists.Where(x => x.ItemId == itemId).FirstOrDefault();
            item.status = true;

            Update(item);
        }

        public List<MindList> GetMyMindList(int id)
        {
            var values = _context.MindLists
                    .Include(x => x.Item).Include(x => x.AppUser).Where(x => x.UserId == id && x.status==true).ToList();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

            return values;
        }

        public List<MindList> GetMyMindListByUser(int UserId)
        {
            var values = _context.MindLists
                   .Include(x => x.Item).ThenInclude(x => x.ItemDetail).ThenInclude(x => x.Brand).Include(x => x.AppUser).Where(x => x.UserId == UserId && x.status == true).ToList();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

            return values;
        }

        public List<MindList> GetMyMindListByUserAndItem(int UserId, int ItemId)
        {
            var values = _context.MindLists
                   .Include(x => x.Item).Include(x => x.AppUser).Where(x => x.UserId == UserId && x.ItemId == ItemId && x.status==true).ToList();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

            return values;
        }

        public List<MindList> GetMyMindListItemsByUserAndItem(int UserId, int ItemId)
        {
            var values = _context.MindLists
                   .Include(x => x.Item).Include(x => x.AppUser).Where(x => x.UserId == UserId && x.ItemId == ItemId && x.status==false).ToList();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

            return values;
        }
    }
}
