using ECommerce.DataAccessLayer.CQRS.Results.ItemAdsResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.CQRS.Queries.ItemAds
{
    public class GetMyOpenItemAdsQuery : IRequest<List<GetMyOpenItemAdsQueryResult>>
    {
        public int UserId { get; set; }

        public GetMyOpenItemAdsQuery(int userId)
        {
            UserId = userId;
        }
    }
}
