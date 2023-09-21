using AkademiPlusMicroservice.Catalog.Dtos.CategoryDtos;
using AkademiPlusMicroservice.Catalog.Services.CategoryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryList() 
        {
            var values = await _categoryService.GetAllCategories();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(string id) 
        {
            var value = await _categoryService.GetByIdCategory(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto) 
        {
            await _categoryService.CreateCategory(createCategoryDto);
            return Ok("Kategori eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto) 
        {
            await _categoryService.UpdateCategory(updateCategoryDto);
            return Ok("Kategori güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(string id) 
        {
            await _categoryService.DeleteCategory(id);
            return Ok("Kategori silindi");
        }
    }
}
