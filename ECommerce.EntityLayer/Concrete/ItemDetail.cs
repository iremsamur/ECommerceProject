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
        public DateTime ItemAnnouncementDate { get; set; }//ilan tarihi
        public ICollection<Item> Items { get; set; }
       
    }
}
