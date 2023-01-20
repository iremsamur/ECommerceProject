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
        public string Name { get; set; }
        public string ShowcaseImage { get; set; }

        public string ItemNo { get; set; }//ürün no-ilan no
        //brandID gelir marka için diğerleri sonra eklenecek
        public double NewPrice { get; set; }
        public double OldPrice { get; set; }
        public double DiscountRate { get; set; }

        public DateTime AnnouncementDate { get; set; }//ilan tarihi
        public int DetailID { get; set; }

        public string SubCategoryName { get; set; }
        public int SubCategoryID { get; set; }
        public string Picture { get; set; }
        public int ImageID { get; set; }
    }
}
