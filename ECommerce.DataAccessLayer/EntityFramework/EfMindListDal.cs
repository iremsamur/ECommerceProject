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
        public List<MindList> GetMyMindList(int id)
        {
            var values = _context.MindLists
                    .Include(x => x.Item).Include(x => x.AppUser).Where(x => x.UserId == id).ToList();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

            return values;
        }

        public List<MindList> GetMyMindListByUser(int UserId)
        {
            var values = _context.MindLists
                   .Include(x => x.Item).ThenInclude(x => x.ItemDetail).ThenInclude(x => x.Brand).Include(x => x.AppUser).Where(x => x.UserId == UserId).ToList();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

            return values;
        }

        public List<MindList> GetMyMindListByUserAndItem(int UserId, int ItemId)
        {
            var values = _context.MindLists
                   .Include(x => x.Item).Include(x => x.AppUser).Where(x => x.UserId == UserId && x.ItemId == ItemId).ToList();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

            return values;
        }
    }
}
