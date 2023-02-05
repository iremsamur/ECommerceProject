using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.ItemDTOs
{
    public class UpdateItemDTO
    {
        public int ItemID{ get; set; }
        public string ItemName { get; set; }
        public string ItemShowcaseImage { get; set; }
        public string ItemSubShowcaseImage { get; set; }
        public int? ItemDetailID { get; set; }
        public int? SubCategoryID { get; set; }
        public int? ItemImageID { get; set; }
        public bool status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
