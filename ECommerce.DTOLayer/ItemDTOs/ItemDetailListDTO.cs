using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.ItemDTOs
{
    public class ItemDetailListDTO
    {

        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemShowcaseImage { get; set; }
    
        public int ItemDetailID { get; set; }
      
        public int SubCategoryID { get; set; }
     
        public int ItemImageID { get; set; }

        public string ItemPicture { get; set; }

        public string ItemNo { get; set; }
        public double ItemNewPrice { get; set; }
        public double ItemOldPrice { get; set; }
        public double ItemDiscount { get; set; }
        public DateTime ItemAnnouncementDate { get; set; }//ilan tarihi





    }
}
