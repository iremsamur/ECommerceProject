using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.DTOLayer.CommentDTOs;
using ECommerce.DTOLayer.ItemDTOs;
using ECommerce.DTOLayer.SubCategoryDTOs;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.UILayer.ViewComponents.GetAdsBySameCategoriesItems
{
	public class _GetAdsBySameCategoriesItems : ViewComponent
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;

        public _GetAdsBySameCategoriesItems(IItemService itemService, IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(List<SubCategoryDTO> subCategoryDTO)
        {
            var values = _mapper.Map<List<SubCategory>>(subCategoryDTO);
            var items = _itemService.TGetItemsBySubCategory(values);
            var mappingItems = _mapper.Map<List<ItemDetailListDTO>>(items);//buradaki hataya bakılacak
            return View(mappingItems);
        }

    }
}
