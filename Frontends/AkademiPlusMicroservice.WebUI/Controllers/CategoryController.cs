using AkademiPlusMicroservice.WebUI.Dtos;
using AkademiPlusMicroservice.WebUI.Dtos.CategoryDtos;
using AkademiPlusMicroservice.WebUI.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace AkademiPlusMicroservice.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService, IHttpClientFactory httpClientFactory)
        {
            _categoryService = categoryService;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5011/api/categories");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var jsonObject = JObject.Parse(jsonData);
            var data = jsonObject["data"].ToString();
            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(data);
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCategoryDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5011/api/categories", stringContent);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCategory(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5011/api/categories/{id}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var jsonObject = JObject.Parse(jsonData);
            var data = jsonObject["data"].ToString();
            var values = JsonConvert.DeserializeObject<UpdateCategoryDto>(data);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory2(UpdateCategoryDto updateCategoryDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateCategoryDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5011/api/categories", stringContent);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteCategory(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var resoponseMessage = await client.DeleteAsync("http://localhost:5011/api/categories?id=" + id);
            return RedirectToAction("Index");
        }
    }
}
