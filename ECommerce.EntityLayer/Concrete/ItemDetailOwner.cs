using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class ItemDetailOwner : BaseEntity
    {
        public int OwnerId { get; set; }
        public int ItemDetailId { get; set; }

        public virtual AppUser OwnerUser { get; set; }
        public virtual ItemDetail ItemAdDetail { get; set; }
    }
}
