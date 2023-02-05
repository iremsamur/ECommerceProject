using ECommerce.DataAccessLayer.CQRS.Queries.ItemAds;
using ECommerce.DataAccessLayer.CQRS.Results.ItemAdsResults;
using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IItemOwnerService : IGenericService<ItemOwner>
    {
        public List<ItemOwner> TGetItemOwnerByLoggedUser(int userId);

        public Task<List<GetMyOpenItemAdsQueryResult>> GetMyOpenItemAds(int UserID);
    }
}
