using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void TDelete(Comment t)
		{
			throw new NotImplementedException();
		}

		public Comment TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Comment> TGetItemWithCommentByID(int id)
		{
			return _commentDal.GetCommentListByItem(id);
		}

		public List<Comment> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TInsert(Comment t)
		{
			_commentDal.Insert(t);
		}

		public void TUpdate(Comment t)
		{
			throw new NotImplementedException();
		}
	}
}
