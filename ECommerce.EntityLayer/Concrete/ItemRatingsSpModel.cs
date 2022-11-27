using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class ItemRatingsSpModel
    {
        //stored procedure'ün getirmesini istediğimiz verileri tutacak model
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemShowcaseImage { get; set; }
        public string CategoryName { get; set; }
        public int ItemRatingID { get; set; }

        public int ItemTotalRatingScore { get; set; }
    }
}
