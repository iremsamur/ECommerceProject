using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.UILayer.Models
{
    public class UpdateItemAdsViewModel
    {
        public int ItemID { get; set; }
        [Required(ErrorMessage = "Ürün adı boş geçilemez!")]
        [MinLength(5, ErrorMessage = "Ürün adı en az 5 karakter olmalıdır!")]
        [MaxLength(50, ErrorMessage = "Ürün adı en fazla 50 karakter olmalıdır!")]
        public string ItemName { get; set; }
        [Required(ErrorMessage = "Ürün ana resmi boş geçilemez!")]
        public IFormFile ItemShowcaseImage { get; set; }
        [Required(ErrorMessage = "Ürün alt resmi boş geçilemez!")]
        public IFormFile ItemSubShowcaseImage { get; set; }
        public int? ItemDetailID { get; set; }

        public int? SubCategoryID { get; set; }
        public int? ItemImageID { get; set; }
    }

}
