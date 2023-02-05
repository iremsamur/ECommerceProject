using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.CQRS.Queries.ItemAds;
using ECommerce.DataAccessLayer.CQRS.Results.ItemAdsResults;
using ECommerce.EntityLayer.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.CQRS.Handlers.ItemAdsHandlers
{
    public class GetMyOpenItemAdsHandlers : IRequestHandler<GetMyOpenItemAdsQuery, List<GetMyOpenItemAdsQueryResult>>
    {
        private readonly Context _context;

        public GetMyOpenItemAdsHandlers(Context context)
        {
            _context = context;
        }

        public async Task<List<GetMyOpenItemAdsQueryResult>> Handle(GetMyOpenItemAdsQuery request, CancellationToken cancellationToken)
        {
            return await _context.ItemOwners.Include(x => x.OwnerUser).Include(x => x.ItemAd).ThenInclude(x => x.ItemDetail).Where(x => x.OwnerId == request.UserId && x.status==true).Select(x => new GetMyOpenItemAdsQueryResult
            {
                ItemName = x.ItemAd.ItemName,
                ItemShowcaseImage = x.ItemAd.ItemShowcaseImage,
                ItemNo = x.ItemAd.ItemDetail.ItemNo,
                ItemNewPrice = x.ItemAd.ItemDetail.ItemNewPrice,
                ItemOldPrice = x.ItemAd.ItemDetail.ItemOldPrice,
                ItemDiscount = x.ItemAd.ItemDetail.ItemDiscount,
                ItemAdType = x.ItemAd.ItemDetail.ItemAdType,
                ItemAnnouncementDate = x.ItemAd.ItemDetail.ItemAnnouncementDate,
                ItemSellerType = x.ItemAd.ItemDetail.ItemSellerType,
                gGuarantee = x.ItemAd.ItemDetail.gGuarantee,
                FromWho = x.ItemAd.ItemDetail.FromWho,
                ItemStatus = x.ItemAd.ItemDetail.ItemStatus,
                Description = x.ItemAd.ItemDetail.Description,
                ItemDetailDescription = x.ItemAd.ItemDetail.ItemDetailDescription,
                Status=x.status


            }).AsNoTracking().ToListAsync();
           
         





        }
    }
}
