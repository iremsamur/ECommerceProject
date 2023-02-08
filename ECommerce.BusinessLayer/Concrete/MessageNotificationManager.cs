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
    public class MessageNotificationManager : IMessageNotificationService
    {
        IMessageNotificationDal _messageNotificationDal;

        public MessageNotificationManager(IMessageNotificationDal messageNotificationDal)
        {
            _messageNotificationDal = messageNotificationDal;
        }

        public void TDelete(MessageNotification t)
        {
            throw new NotImplementedException();
        }

        public MessageNotification TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MessageNotification> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(MessageNotification t)
        {
            _messageNotificationDal.Insert(t);
        }

        public void TUpdate(MessageNotification t)
        {
            throw new NotImplementedException();
        }
    }
}
