using Microsoft.AspNetCore.Http;

namespace ECommerce.UILayer.Models
{
    public class CreateNewItemAdsViewModel
    {
        public string ItemName { get; set; }
        public IFormFile ItemShowcaseImage { get; set; }
        public IFormFile ItemSubShowcaseImage { get; set; }
        public int? ItemDetailID { get; set; }
        public int? SubCategoryID { get; set; }
        public int? ItemImageID { get; set; }
    }
}
