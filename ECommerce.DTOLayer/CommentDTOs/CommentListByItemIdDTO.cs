using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.CommentDTOs
{
	public class CommentListByItemIdDTO
	{
        public int CommentID { get; set; }
       
        public int AppUserID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }


        public DateTime CommentDate { get; set; }

        public string CommentContent { get; set; }

        public bool CommentState { get; set; }
    
        public int ItemID { get; set; }

    }
}
