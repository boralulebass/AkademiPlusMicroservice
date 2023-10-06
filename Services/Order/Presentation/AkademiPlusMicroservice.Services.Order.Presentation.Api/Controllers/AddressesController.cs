using AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Commands;
using AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.Services.Order.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAddressList() 
        {
            var value = await _mediator.Send(new GetAllAddressQueryRequest());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress(CreateAddressCommandRequest commandRequest)
        {
            await _mediator.Send(commandRequest);
            return Ok("Adres Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            await _mediator.Send(new RemoveAddressCommandRequest(id));
            return Ok("Adres Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddressById(int id)
        {
            var value = await _mediator.Send(new GetAddressQueryRequest(id));
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAddress(UpdateAddressCommandRequest commandRequest)
        {
            await _mediator.Send(commandRequest);
            return Ok("Adres Güncellendi");
        }
    }
}
