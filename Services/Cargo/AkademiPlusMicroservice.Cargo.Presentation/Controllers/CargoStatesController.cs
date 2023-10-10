using AkademiPlusMicroservice.Cargo.BusinessLayer.Abstract;
using AkademiPlusMicroservice.Cargo.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.Cargo.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoStatesController : ControllerBase
    {
        private readonly ICargoStateService _cargoStateService;

        public CargoStatesController(ICargoStateService CargoStateService)
        {
            _cargoStateService = CargoStateService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCargoState()
        {
            var values = await _cargoStateService.TGetAllAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCargoState(CargoState CargoState)
        {
            await _cargoStateService.TCreateAsync(CargoState);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCargoState(CargoState CargoState)
        {
            await _cargoStateService.TUpdateAsync(CargoState);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCargoState(int id)
        {
            var value = await _cargoStateService.TGetByIdAsync(id);
            await _cargoStateService.TDeleteAsync(value);
            return Ok();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCargoStateById(int id)
        {
            var value = await _cargoStateService.TGetByIdAsync(id);
            return Ok(value);
        }
    }
}
