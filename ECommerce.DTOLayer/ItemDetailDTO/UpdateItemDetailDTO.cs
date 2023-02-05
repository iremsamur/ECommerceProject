using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.ItemDetailDTO
{
    public class UpdateItemDetailDTO
    {
        public int ItemDetailID { get; set; }
        public string ItemNo { get; set; }
        public double ItemNewPrice { get; set; }


        public double ItemOldPrice { get; set; }


        public double ItemDiscount { get; set; }



        public int ItemAdType { get; set; }// ürünün ilan türü - satılık ürün/kiralık ürün

        public DateTime ItemAnnouncementDate { get; set; }//ilan tarihi

        public int? BrandID { get; set; }

        public int ItemSellerType { get; set; }//sahibinden mi kurum mu satıyor

        public string gGuarantee { get; set; }//garantisi
        public string FromWho { get; set; } //kimden


        public string ItemStatus { get; set; }//durumu - 2.el, 1.el


        public string Description { get; set; } //açıklaması

        public string ItemDetailDescription { get; set; }//ürün detayı açıklaması örneğin bilgisayar için ram, cpu vb.
        public int? AppUserId { get; set; }

        public bool status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
