using AkademiPlusMicroservice.Shared.Dtos;
using AkademiPlusMicroservice.WebUI.Dtos.CategoryDtos;
using AkademiPlusMicroservice.WebUI.Services.Abstract;

namespace AkademiPlusMicroservice.WebUI.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IHttpClientFactory _httpClient;

        public CategoryService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<Response<NoContent>> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteCategory(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultCategoryDto>> GetAllCategories()
        {

            throw new NotImplementedException();
        }

        public Task<Response<ResultCategoryDto>> GetByIdCategory(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}