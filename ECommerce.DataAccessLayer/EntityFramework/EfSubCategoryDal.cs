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
        private readonly Context _context;

        public EfSubCategoryDal(Context context) : base(context)
        {
            _context = context;
        }
        public int GetCountOfSubCategories()
        {
            int count = _context.SubCategories.ToList().Count();

            return count;
        }
        public List<SubCategory> GetSubCategoriesByCategoryID(int CategoryID)
        {
            var values = _context.SubCategories.Include(x => x.Category).Distinct().ToList();
            return values;

        }
    }
}
