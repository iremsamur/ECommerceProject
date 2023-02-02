using ECommerce.DTOLayer.BrandDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.ItemDTOs
{
	public class ItemDetailDTO
	{
        public int ItemDetailID { get; set; }
        public string ItemNo { get; set; }
        public double ItemNewPrice { get; set; }
        public double ItemOldPrice { get; set; }
        public double ItemDiscount { get; set; }

        public int ItemAdType { get; set; }

        public DateTime ItemAnnouncementDate { get; set; }

        public BrandDTO Brand { get; set; }
 
        public string gGuarantee { get; set; }
        public string FromWho { get; set; } 
        public string ItemStatus { get; set; }
        public string Description { get; set; } 
        public string ItemDetailDescription { get; set; }
    }
}
