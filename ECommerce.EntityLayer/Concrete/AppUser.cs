using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
	public class AppUser : IdentityUser<int>
	{
        public string Name
        {
            get; set;
        }
    
        public string Surname
        {
            get; set;
        }
        public string ImageUrl
        {
            get; set;
        }
        public string Gender
        {
            get; set;
        }
        public ICollection<Comment> Comments { get; set; }
         //item-user çoka çok ilişki sepete eklenen ürün
        public virtual ICollection<MindList> MindLists { get; set; }
    }
}
