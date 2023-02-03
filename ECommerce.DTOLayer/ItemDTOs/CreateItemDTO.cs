using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.ItemDTOs
{
    public class CreateItemDTO
    {
        public string ItemName { get; set; }
        public string ItemShowcaseImage { get; set; }
        public string ItemSubShowcaseImage { get; set; }
        public int? ItemDetailID { get; set; }
        public int? SubCategoryID { get; set; }
        public int? ItemImageID { get; set; }
    }
}
