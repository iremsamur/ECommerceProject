using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.CommentDTOs
{
	public class AddCommentDTO
	{
      
        public int AppUserID { get; set; }


        public DateTime CommentDate { get; set; }

        public string CommentContent { get; set; }

        public bool CommentState { get; set; }

        public int ItemID { get; set; }
    }
}
