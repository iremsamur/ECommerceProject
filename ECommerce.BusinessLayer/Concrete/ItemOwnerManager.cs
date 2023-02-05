using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.CQRS.Queries.ItemAds;
using ECommerce.DataAccessLayer.CQRS.Results.ItemAdsResults;
using ECommerce.EntityLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Concrete
{
    public class ItemOwnerManager : IItemOwnerService
    {
        private readonly IItemOwnerDal _itemOwnerDal;
        private readonly IMediator _mediator;

        public ItemOwnerManager(IItemOwnerDal itemOwnerDal, IMediator mediator)
        {
            _itemOwnerDal = itemOwnerDal;
            _mediator = mediator;
        }

        public List<ItemOwner> TGetItemOwnerByLoggedUser(int userId)
        {
            return _itemOwnerDal.GetItemOwnerByLoggedUser(userId);
        }

        public void TDelete(ItemOwner t)
        {
            throw new NotImplementedException();
        }

        public ItemOwner TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ItemOwner> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(ItemOwner t)
        {
            _itemOwnerDal.Insert(t);
        }

        public void TUpdate(ItemOwner t)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetMyOpenItemAdsQueryResult>> GetMyOpenItemAds(int UserID)
        {
            var values = await _mediator.Send(new GetMyOpenItemAdsQuery(UserID));
            return values;
        }

        public void TChangeItemOwnerStatusToActive(int id)
        {
            _itemOwnerDal.ChangeItemOwnerStatusToActive(id);
        }

        public void TChangeItemOwnerStatusToPassive(int id)
        {
            _itemOwnerDal.ChangeItemOwnerStatusToPassive(id);
        }
    }
}
