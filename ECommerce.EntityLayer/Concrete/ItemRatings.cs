using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
	public class ItemRatings
	{
		//en çok beğenilen ürünleri tutar.
		[Key]
		public int ItemRatingID { get; set; }
	
        public int ItemTotalRatingScore { get; set; }
        public int ItemRatingCount { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; }
        //trigger ile beğen butonuna basıldığı anda totalratingi 1 arttırır. Blog örneğindeki gibi


    }
}
