using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
	public class NewItemNotification
	{
        [Key]
        public int NotificationID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemShowcaseImage { get; set; }

    }
}
