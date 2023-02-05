using ECommerce.DTOLayer.ItemDetailDTO;
using ECommerce.DTOLayer.ItemDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.ValidationRules.ItemDetailValidation
{
    public class ItemDetailAddValidator : AbstractValidator<CreateItemDetailDTO>
    {
        public ItemDetailAddValidator()
        {
            RuleFor(x => x.ItemOldPrice).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez!");
            RuleFor(x => x.ItemDiscount).NotEmpty().WithMessage("Ürün indirim oranı boş geçilemez!");
            RuleFor(x => x.ItemAdType).NotEmpty().WithMessage("İlan türü boş geçilemez!");
            RuleFor(x => x.gGuarantee).NotEmpty().WithMessage("Ürün garantisi alanı boş geçilemez!");
            RuleFor(x => x.ItemStatus).NotEmpty().WithMessage("Ürün durumu alanı boş geçilemez!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Ürün açıklaması alanı boş geçilemez!");
            RuleFor(x => x.ItemDetailDescription).NotEmpty().WithMessage("Ürün detayı alanı boş geçilemez!");
            RuleFor(x => x.Description).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız!");

            RuleFor(x => x.Description).MaximumLength(250).WithMessage("Lütfen en fazla 50 karakter veri girişi yapınız!");
            RuleFor(x => x.ItemDetailDescription).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız!");

            RuleFor(x => x.ItemDetailDescription).MaximumLength(1000).WithMessage("Lütfen en fazla 1000 karakter veri girişi yapınız!");


        }
    }
}
