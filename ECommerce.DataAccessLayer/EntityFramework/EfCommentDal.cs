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
	public class EfCommentDal : GenericRepository<Comment>, ICommentDal
	{
        private readonly Context _context;

        public EfCommentDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Comment> GetCommentListByItem(int id)
		{
            var values = _context.Comments.Include(x => x.AppUser).Include(x => x.Item).Where(x => x.ItemID == id).ToList();
            return values;
        }
	}
}
