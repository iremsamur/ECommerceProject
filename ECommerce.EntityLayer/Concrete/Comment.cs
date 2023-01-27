using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
	public class Comment : BaseEntity
	{

        [Key]
        public int CommentID { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserID { get; set; }


        public DateTime CommentDate { get; set; }
    
        public string CommentContent { get; set; }

        public bool CommentState { get; set; }
        public Item Item { get; set; }
        public int ItemID { get; set; }


    }

}
