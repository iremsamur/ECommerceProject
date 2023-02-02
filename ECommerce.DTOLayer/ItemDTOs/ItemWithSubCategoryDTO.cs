﻿using ECommerce.DTOLayer.SubCategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.ItemDTOs
{
    public class ItemWithSubCategoryDTO
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemShowcaseImage { get; set; }
        public ItemDetailDTO ItemDetail { get; set; }
        public int? ItemDetailID { get; set; }
        public SubCategoryDTO SubCategory { get; set; }
        public int? SubCategoryID { get; set; }
    }
}
