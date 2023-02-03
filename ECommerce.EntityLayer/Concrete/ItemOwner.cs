using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class ItemOwner : BaseEntity
    {
        public int OwnerId { get; set; }
        public int ItemAdId { get; set; }

        public virtual AppUser OwnerUser { get; set; }
        public virtual Item ItemAd { get; set; }
    }
}
