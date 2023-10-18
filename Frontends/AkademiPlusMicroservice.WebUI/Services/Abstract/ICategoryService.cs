using AkademiPlusMicroservice.Shared.Dtos;
using AkademiPlusMicroservice.WebUI.Dtos.CategoryDtos;

namespace AkademiPlusMicroservice.WebUI.Services.Abstract
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategories();
        Task<Response<ResultCategoryDto>> GetByIdCategory(string id);
        Task<Response<NoContent>> CreateCategory(CreateCategoryDto createCategoryDto);
        Task<Response<NoContent>> UpdateCategory(UpdateCategoryDto updateCategoryDto);
        Task<Response<NoContent>> DeleteCategory(string id);
    }
}
