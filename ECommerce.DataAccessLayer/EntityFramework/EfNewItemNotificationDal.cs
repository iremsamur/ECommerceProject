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
        public List<NewItemNotification> GetNewItemNotification()
        {
            using (var context = new Context())
            {
                var values = context.NewItemNotifications
                    .ToList();

                return values;
            }
        }
    }
}
