using AkademiPlusMicroservice.Shared.Dtos;
using AkademiPlusMicroservice.WebUI.Dtos.ProductDtos;
using AkademiPlusMicroservice.WebUI.Services.Abstract;

namespace AkademiPlusMicroservice.WebUI.Services.Concrete
{
    public class ProductService : IProductService
    {
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