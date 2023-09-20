using AkademiPlusMicroservice.Catalog.Dtos.CategoryDtos;
using AkademiPlusMicroservice.Catalog.Dtos.ProductDtos;
using AkademiPlusMicroservice.Catalog.Models;
using AutoMapper;

namespace AkademiPlusMicroservice.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();

            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
        }
    }
}
