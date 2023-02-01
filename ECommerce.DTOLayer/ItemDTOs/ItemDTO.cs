using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.ItemDTOs
{
	public class ItemDTO
	{
        public string ItemName { get; set; }
        public string ItemShowcaseImage { get; set; }
        public ItemDetailDTO ItemDetail { get; set; }
       
    }
}
