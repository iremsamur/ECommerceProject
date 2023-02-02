using AutoMapper;
using ECommerce.DTOLayer;
using ECommerce.DTOLayer.ItemDTOs;
using ECommerce.DTOLayer.MindListDTOs;
using ECommerce.DTOLayer.SubCategoryDTOs;
using ECommerce.DTOLayer.UserDTOs;
using ECommerce.EntityLayer.Concrete;

namespace ECommerce.UILayer.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
         
      
            CreateMap<Item, ItemDetailListDTO>().ReverseMap();
            CreateMap<ItemDetail, ItemDetailDTO>().ReverseMap();
            CreateMap<MindList, MindListDTO>().ReverseMap();
            CreateMap<AppUser, UserDTO>().ReverseMap();
            CreateMap<Item, ItemDTO>().ReverseMap();
            CreateMap<SubCategory, SubCategoryDTO>().ReverseMap();
            CreateMap<Item, ItemWithSubCategoryDTO>().ReverseMap();
            CreateMap<Item, CreateItemDTO>().ReverseMap();

        }
    }
}
