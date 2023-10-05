using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.AddressDtos;
using AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Commands;
using AkademiPlusMicroservice.Services.Order.Core.Application.Interfaces;
using AkademiPlusMicroservice.Services.Order.Core.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest, UpdateAddressDto>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Address> _repository;

        public UpdateAddressCommandHandler(IMapper mapper, IRepository<Address> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<UpdateAddressDto> Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var value = new Address
            {
                AddressId = request.AddressId,
                City = request.City,
                Detail = request.Detail,
                District = request.District,
                UserId = request.UserId
            };
            await _repository.UpdateAsync(value);
            return _mapper.Map<UpdateAddressDto>(value);
        }
    }
}
