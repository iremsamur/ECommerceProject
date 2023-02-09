﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class Item:BaseEntity
    {
        //tüm genel satılık/kiralık ilanı verilebilen ürünleri temsil eder
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemShowcaseImage { get; set; }
        public string ItemSubShowcaseImage { get; set; }
        public ItemDetail ItemDetail { get; set; }
        public int? ItemDetailID { get; set; }
        public SubCategory SubCategory { get; set; }
        public int? SubCategoryID { get; set; }

        public ItemImage ItemImage { get; set; }
        public int? ItemImageID { get; set; }

        public ICollection<MessageNotification> MessageNotifications { get; set; }

        public ICollection<Comment> Comments { get; set; }

        //item-user çoka çok ilişki sepete eklenen ürün
        public virtual ICollection<MindList> MindLists { get; set; }
        /*public virtual ICollection<AdItems> AdItemss { get; set; }*///Item- Individual çoka çok ilişkisi
        public virtual ICollection<ItemOwner> ItemOwners { get; set; }





    }
}
