using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.NewItemNotificationDTOs
{
    public class NewItemNotificationDTO
    {
        public int NotificationID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemShowcaseImage { get; set; }
    }
}
