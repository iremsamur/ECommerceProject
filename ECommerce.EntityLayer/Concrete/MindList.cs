using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class MindList
    {
        //item-user çoka çok ilişki sepete eklenen ürün- mindlist aklımdakiler listesi yani aslında sepet
        [Key]
        public int MindListId { get; set; }
        public int UserId{ get; set; }
        public int ItemId { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual Item Item { get; set; }
    }
}

