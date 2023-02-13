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
    public class EfNewItemNotificationDal : GenericRepository<NewItemNotification>, INewItemNotificationDal
    {
        private readonly Context _context;

        public EfNewItemNotificationDal(Context context) : base(context)
        {
            _context = context;
        }
        public List<NewItemNotification> GetNewItemNotification()
        {
            var values = _context.NewItemNotifications
                   .ToList();

            return values;
        }
    }
}
