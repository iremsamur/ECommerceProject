﻿using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IMessageNotificationService : IGenericService<MessageNotification>
    {
        public List<MessageNotification> TGetMessageNotifications(int id);
        public int TGetMessageNotificationsCount(int id);
    }
}