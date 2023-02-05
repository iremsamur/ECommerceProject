﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.ItemOwnerDTOs
{
    public class ItemOwnerDTO
    {
        public int OwnerId { get; set; }
        public int ItemAdId { get; set; }
        public bool status { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


    }
}
