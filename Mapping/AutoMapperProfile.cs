using AutoMapper;
using StokTakipApi.DTOs;
using StokTakipApi.Entities;
namespace StokTakipApi.Mapping
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
