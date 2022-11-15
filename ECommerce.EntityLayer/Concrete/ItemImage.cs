using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class ItemImage : BaseEntity
    {
        [Key]
        public int ItemImageID { get; set; }
        public string ItemPicture { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
