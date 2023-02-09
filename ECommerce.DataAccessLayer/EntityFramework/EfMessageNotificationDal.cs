using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.Repository;
using ECommerce.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.EntityFramework
{
    public class EfMessageNotificationDal : GenericRepository<MessageNotification>, IMessageNotificationDal
    {
        public List<MessageNotification> GetMessageNotifications(int id)
        {
            using (var context = new Context())
            {
                var values = context.MessageNotifications
                    .Include(x => x.ReceiverUserForNotification).Include(x => x.ItemAd).Include(x => x.SenderUserForNotification).Where(x => x.ReceiverID == id).ToList();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

                return values;
            }
        }

        public int GetMessageNotificationsCount(int id)
        {
            using (var context = new Context())
            {
               int messageNotificationCount= context.MessageNotifications
                    .Include(x => x.ReceiverUserForNotification).Include(x => x.ItemAd).Include(x => x.SenderUserForNotification).Where(x => x.ReceiverID == id).ToList().Count();//giriş yapan o kullanıcının aklımdakiler listesi gelsin.

                return messageNotificationCount;
            }
        }
    }
}
