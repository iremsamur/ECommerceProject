using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class MessageNotification : BaseEntity
    {
        [Key]
        public int MessageNotificationId { get; set; }

        public int? SenderID { get; set; }
        public int? ReceiverID { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }

        public AppUser SenderUserForNotification { get; set; }//Gönderici
        public AppUser ReceiverUserForNotification { get; set; }//Alıcı
    }
}
