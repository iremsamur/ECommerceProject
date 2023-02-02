using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class ItemDetail:BaseEntity
    {
        [Key]
        public int ItemDetailID { get; set; }
        //diğer detay bilgiler gelecek
        public string ItemNo { get; set; }//ürün no-ilan no
        //brandID gelir marka için diğerleri sonra eklenecek
        public double ItemNewPrice { get; set; }
        public double ItemOldPrice { get; set; }
        public double ItemDiscount { get; set; }

        public int ItemAdType{ get; set; }// ürünün ilan türü - satılık ürün/kiralık ürün

        public DateTime ItemAnnouncementDate { get; set; }//ilan tarihi
        public ICollection<Item> Items { get; set; }

        public Brand Brand { get; set; }
        public int BrandID { get; set; }

        public int ItemSellerType { get; set; }//sahibinden mi kurum mu satıyor
        public string gGuarantee { get; set; }//garantisi
        public string FromWho { get; set; } //kimden
        public string ItemStatus { get; set; }//durumu - 2.el, 1.el
        public string Description { get; set; } //açıklaması
        public string ItemDetailDescription { get; set; }//ürün detayı açıklaması örneğin bilgisayar için ram, cpu vb.


    }
}
