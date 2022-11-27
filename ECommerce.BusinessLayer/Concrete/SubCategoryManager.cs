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
	public class SubCategoryManager : ISubCategoryService
	{
		ISubCategoryDal _subCategoryDal;

		public SubCategoryManager(ISubCategoryDal subCategoryDal)
		{
			_subCategoryDal = subCategoryDal;
		}

		public void TDelete(SubCategory t)
		{
			throw new NotImplementedException();
		}

		public SubCategory TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public int TGetCountOfSubCategories()
		{
			return _subCategoryDal.GetCountOfSubCategories();
		}

		public List<SubCategory> TGetList()
		{
			throw new NotImplementedException();
		}

		public List<SubCategory> TGetSubCategoriesByCategoryID(int CategoryID)
		{
			return _subCategoryDal.GetSubCategoriesByCategoryID(CategoryID);
		}

		public void TInsert(SubCategory t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(SubCategory t)
		{
			throw new NotImplementedException();
		}
	}
}
