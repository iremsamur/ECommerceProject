using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
	public class CompanySeller
	{
        [Key]
        public int CompanySellerId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int StaffUserId { get; set; }

        public virtual ICollection<AdItems> AdItems { get; set; }//Item- Company çoka çok ilişkisi

        public string CompanyName { get; set; }
        public string CompanyPicture { get; set; }
        public string CompanyNumber { get; set; }
        public string CompanySectorName { get; set; }
        public string CompanyAbout { get; set; }

    }
}
