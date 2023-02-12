using AutoMapper;
using ECommerce.DTOLayer;
using ECommerce.DTOLayer.CompanySellerDTOs;
using ECommerce.DTOLayer.IndividualSellerDTOs;
using ECommerce.DTOLayer.ItemDetailDTO;
using ECommerce.DTOLayer.ItemDetailOwnerDTOs;
using ECommerce.DTOLayer.ItemDTOs;
using ECommerce.DTOLayer.ItemOwnerDTOs;
using ECommerce.DTOLayer.MindListDTOs;
using ECommerce.DTOLayer.NewItemNotificationDTOs;
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
            CreateMap<ItemDetail, CreateItemDetailDTO>().ReverseMap();
            CreateMap<ItemOwner, ItemOwnerDTO>().ReverseMap();
            CreateMap<ItemDetailOwner, ItemDetailOwnerDTO>().ReverseMap();
            CreateMap<Item, UpdateItemAdDTO>().ReverseMap();
            CreateMap<ItemDetail, UpdateItemDetailDTO>().ReverseMap();
            CreateMap<AppUser,AppUserDTO>().ReverseMap();
            CreateMap<CompanySeller, CompanySellerDTO>().ReverseMap();
            CreateMap<IndividualSeller, IndividualSellerDTO>().ReverseMap();
            CreateMap<AppUser, AppUserIndividualDTO>().ReverseMap();
            CreateMap<NewItemNotification, NewItemNotificationDTO>().ReverseMap();

        }
    }
}
