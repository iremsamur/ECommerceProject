using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class Brand : BaseEntity
    {
        [Key]
        public int BrandID { get; set; }
        public string BrandTitle { get; set; }
        public ICollection<ItemDetail> ItemDetails { get; set; }

    }
}
