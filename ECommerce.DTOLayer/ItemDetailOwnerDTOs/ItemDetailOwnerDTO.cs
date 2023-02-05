using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.ItemDetailOwnerDTOs
{
    public class ItemDetailOwnerDTO
    {
        public int OwnerId { get; set; }
        public int ItemDetailId { get; set; }
        public bool status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
