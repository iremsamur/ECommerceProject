using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.Repository;
using ECommerce.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ECommerce.DataAccessLayer.EntityFramework
{
    public class EfSubCategoryDal : GenericRepository<SubCategory>, ISubCategoryDal
    {
        public int GetCountOfSubCategories()
        {
            using (var context = new Context())
            {
                int count = context.SubCategories.ToList().Count();

                return count;
            }
        }
        public List<SubCategory> GetSubCategoriesByCategoryID(int CategoryID)
        {
            using (var context = new Context())
            {
                var values = context.SubCategories.Include(x => x.Category).Distinct().ToList();
                return values;
            }
            
        }
    }
}
