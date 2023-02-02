using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
	public class Message : BaseEntity
	{
        [Key]
        public int MessageId { get; set; }

        public int? SenderID { get; set; }
        public int? ReceiverID { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }

        //Writer Message 2 foreign key ilişkisi tanımlamaları
        public AppUser SenderUser { get; set; }//Gönderici
        public AppUser ReceiverUser { get; set; }//Alıcı
    }
}
