using AutoMapper;
using EffectiveMobile.Domain.Entities;
using EffectiveMobile.Service.DTOs.DeliveryLocation;
using EffectiveMobile.Service.DTOs.Order;
using EffectiveMobile.Service.DTOs.Region;

namespace EffectiveMobile.Service.Mappers
{
    public  class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<Region,RegionForCreationDto>().ReverseMap();
            CreateMap<Region,RegionForResultDto>().ReverseMap();
            CreateMap<Region,RegionForUpdateDto>().ReverseMap();

            CreateMap<Order,OrderForCreationDto>().ReverseMap();
            CreateMap<Order,OrderForResultDto>().ReverseMap();
            CreateMap<Order,OrderForUpdateDto>().ReverseMap();  

            CreateMap<DeliveryLocation,DeliveryLocationForCreationDto>().ReverseMap();
            CreateMap<DeliveryLocation,DeliveryLocationForResultDto>().ReverseMap();
            CreateMap<DeliveryLocation,DeliveryLocationForUpdateDto>().ReverseMap();
        
        
        }
    }
}
