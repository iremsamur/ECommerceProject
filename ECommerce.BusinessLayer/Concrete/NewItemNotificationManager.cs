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
    public class NewItemNotificationManager : INewItemNotificationService
    {
        INewItemNotificationDal _newItemNotificationDal;

        public NewItemNotificationManager(INewItemNotificationDal newItemNotificationDal)
        {
            _newItemNotificationDal = newItemNotificationDal;
        }

        public List<NewItemNotification> TGetNewItemNotification()
        {
            return _newItemNotificationDal.GetNewItemNotification();
        }
    }
}
