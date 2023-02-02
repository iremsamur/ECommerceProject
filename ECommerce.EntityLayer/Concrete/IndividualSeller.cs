using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
	public class IndividualSeller
	{
        [Key]
        public int IndividualSellerId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int IndividualUserId { get; set; }
        public virtual ICollection<AdItems> AdItems { get; set; }//Item- Individual çoka çok ilişkisi
    }
}
