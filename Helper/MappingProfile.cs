using AutoMapper;
using ThuongMaiDienTuWebAPI.Dto;
using ThuongMaiDienTuWebAPI.Models;

namespace ThuongMaiDienTuWebAPI.Helper
{
    public class MappingProfile :Profile
    {
        public MappingProfile() {
            CreateMap<Product, ProductDto>(); CreateMap<ProductDto, Product>();
        }
    }
}
