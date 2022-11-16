using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
	public class ItemDiscountScore
	{
        //en çok indirime giren ürünleri tutar.
        [Key]
        public int ItemDiscountScoreID { get; set; }
		public int ItemID { get; set; }
        public double ItemTotalDiscountScore { get; set; }
        //yeni fiyat-eski fiyattan indirim miktarını bulup en çok indirime giren ürünleri ön sırada gösterecek
        //procedure ile yapılır
        
    }
}
