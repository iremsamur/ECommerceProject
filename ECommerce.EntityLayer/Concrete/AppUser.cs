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
        public virtual ICollection<ItemOwner> ItemOwners { get; set; }
        public virtual ICollection<ItemDetailOwner> ItemDetailOwners { get; set; }

        //public ICollection<IndividualSeller> IndividualSellers { get; set; }
        //public ICollection<CompanySeller> CompanySellers { get; set; }

        public virtual ICollection<Message> UserSender { get; set; }//Gönderici için WriterMessage ilişkisi
        public virtual ICollection<Message> UserReceiver { get; set; } //alıcı için WriterMessage ilişkisi

   

        public IndividualSeller IndividualSeller { get; set; }
        public int? IndividualSellerId { get; set; }

        public CompanySeller CompanySeller { get; set; }
        public int? CompanySellerId { get; set; }



    }
}
