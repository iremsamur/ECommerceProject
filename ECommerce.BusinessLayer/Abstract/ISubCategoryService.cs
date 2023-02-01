using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
	public interface ISubCategoryService : IGenericService<SubCategory>
	{
		int TGetCountOfSubCategories();
		public List<SubCategory> TGetSubCategoriesByCategoryID(int CategoryID);
        

    }
}
