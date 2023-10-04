using AutoMapper;
using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.AddressDtos;
using AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Queries;
using AkademiPlusMicroservice.Services.Order.Core.Application.Interfaces;
using AkademiPlusMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class GetAllAddressQueryHandler : IRequestHandler<GetAllAddressQueryRequest, List<ResultAddressDto>>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public GetAllAddressQueryHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultAddressDto>> Handle(GetAllAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<List<ResultAddressDto>>(values);
        }
    }
}
