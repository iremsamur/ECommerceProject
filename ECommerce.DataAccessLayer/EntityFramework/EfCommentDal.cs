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
		public List<Comment> GetCommentListByItem(int id)
		{
            using (var context = new Context())
            {
              

                var values = context.Comments.Include(x => x.AppUser).Include(x => x.Item).Where(x => x.ItemID == id).ToList();
                return values;
            }
        }
	}
}
