using AutoMapper;
using ECommerce.DTOLayer;
using ECommerce.DTOLayer.ItemDTOs;
using ECommerce.EntityLayer.Concrete;

namespace ECommerce.UILayer.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
          


            CreateMap<ItemDetailListDTO, Item>();
            CreateMap<Item, ItemDetailListDTO>();




        }
    }
}
