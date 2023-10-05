using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.AddressDtos;
using AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Queries;
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
    public class GetAddressQueryHandler : IRequestHandler<GetAddressQueryRequest, ResultAddressDto>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Address> _repository;

        public GetAddressQueryHandler(IMapper mapper, IRepository<Address> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ResultAddressDto> Handle(GetAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultAddressDto>(value);
        }
    }
}
