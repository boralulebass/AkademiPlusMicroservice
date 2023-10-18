using AkademiPlusMicroservice.WebUI.Dtos.ProductDtos;
using AkademiPlusMicroservice.Shared.Dtos;

namespace AkademiPlusMicroservice.WebUI.Services.Abstract
{
    public interface IProductService
    {
        Task<Response<List<ResultProductDto>>> GetAllProducts();
        Task<Response<ResultProductDto>> GetByIdProduct(string id);
        Task<Response<NoContent>> CreateProduct(CreateProductDto createProductDto);
        Task<Response<NoContent>> UpdateProduct(UpdateProductDto updateProductDto);
        Task<Response<NoContent>> DeleteProduct(string id);
    }
}
