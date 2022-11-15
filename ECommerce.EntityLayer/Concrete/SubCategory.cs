using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class SubCategory:BaseEntity
    {
        [Key]
        public int SubCategoryID { get; set; }
        public string CategoryName { get; set; }
        
        public Category Category { get; set; }
        public int CategoryID { get; set; }

        public ICollection<Item> Items{ get; set; }

    }
}
