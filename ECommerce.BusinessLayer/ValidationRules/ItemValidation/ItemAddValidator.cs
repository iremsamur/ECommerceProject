using ECommerce.DTOLayer.ItemDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.ValidationRules.ItemValidation
{
    public class ItemAddValidator : AbstractValidator<CreateItemDTO>
    {
        public ItemAddValidator()
        {
            RuleFor(x => x.ItemName).NotEmpty().WithMessage("Ürün adı boş geçilemez!");
            RuleFor(x => x.ItemShowcaseImage).NotEmpty().WithMessage("Ürün Resmi boş geçilemez!");
            RuleFor(x => x.ItemSubShowcaseImage).NotEmpty().WithMessage("Ürün Resmi boş geçilemez!");
            RuleFor(x => x.ItemName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız!");
       
            RuleFor(x => x.ItemName).MaximumLength(100).WithMessage("Lütfen en fazla 50karakter veri girişi yapınız!");
        

        }
    }
}
