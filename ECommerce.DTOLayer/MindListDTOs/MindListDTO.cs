using ECommerce.DTOLayer.ItemDTOs;
using ECommerce.DTOLayer.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.MindListDTOs
{
    public class MindListDTO
    {
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public bool status { get; set; }
        public  ItemDTO Item{ get; set; }
        public  UserDTO User { get; set; }
    }
}
