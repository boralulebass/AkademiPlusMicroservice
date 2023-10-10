using AkademiPlusMicroservice.Cargo.BusinessLayer.Abstract;
using AkademiPlusMicroservice.Cargo.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.Cargo.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailsController(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCargoDetail() 
        {
            var values = await _cargoDetailService.TGetAllAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCargoDetail(CargoDetail cargoDetail)
        {
            await _cargoDetailService.TCreateAsync(cargoDetail);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCargoDetail(CargoDetail cargoDetail)
        {
            await _cargoDetailService.TUpdateAsync(cargoDetail);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCargoDetail(int id)
        {
            var value = await _cargoDetailService.TGetByIdAsync(id);
            await _cargoDetailService.TDeleteAsync(value);
            return Ok();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCargoDetailById(int id)
        {
            var value = await _cargoDetailService.TGetByIdAsync(id);
            return Ok(value);
        }
    }
}
