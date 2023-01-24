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
        public string ItemSubShowcaseImage { get; set; }
        public int ItemDetailID { get; set; }
        public int SubCategoryID { get; set; }
        public int ItemImageID { get; set; }
        public string ItemPicture { get; set; }


        public string ItemNo { get; set; }
        public double ItemNewPrice { get; set; }
        public double ItemOldPrice { get; set; }
        public double ItemDiscount { get; set; }

        public string ItemAdType { get; set; }// ürünün ilan türü - satılık ürün/kiralık ürün

        public DateTime ItemAnnouncementDate { get; set; }//ilan tarihi

        public int BrandID { get; set; }
        public string BrandTitle { get; set; }
        public string gGuarantee { get; set; }//garantisi
        public string FromWho { get; set; } //kimden
        public string ItemStatus { get; set; }//durumu - 2.el, 1.el
        public string Description { get; set; } //açıklaması
        public string ItemDetailDescription { get; set; }//ürün detayı açıklaması örneğin bilgisayar için ram, cpu vb.






    }
}
