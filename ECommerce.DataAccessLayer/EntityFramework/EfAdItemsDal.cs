using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.Repository;
using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.EntityFramework
{
    public class EfAdItemsDal : GenericRepository<AdItems>, IAdItemsDal
    {
        private readonly Context _context;

        public EfAdItemsDal(Context context) : base(context)
        {
            _context = context;
        }
    }
}
