using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
	public class ItemDiscountScoresSpModel
	{
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemShowcaseImage { get; set; }
        public string CategoryName { get; set; }
        public double ItemTotalDiscountScore { get; set; }
        public double ItemNewPrice { get; set; }
        public double ItemOldPrice { get; set; }
        public double ItemDiscount { get; set; }
        public int ItemDiscountScoreID { get; set; }



    }
}
