using AkademiPlusMicroservice.Catalog.Dtos.ProductDtos;
using AkademiPlusMicroservice.Catalog.Models;
using AkademiPlusMicroservice.Shared.Dtos;
using AutoMapper;
using MongoDB.Driver;

namespace AkademiPlusMicroservice.Catalog.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;
        public Task<Response<NoContent>> CreateProduct(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ResultProductDto>>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Response<ResultProductDto>> GetByIdProduct(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateProduct(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
