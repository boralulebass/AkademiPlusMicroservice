using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderingDtos;
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
    public class GetOrderQueryHandler : IRequestHandler<GetOrderingQueryRequest, ResultOrderingDto>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Ordering> _repository;

        public GetOrderQueryHandler(IMapper mapper, IRepository<Ordering> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ResultOrderingDto> Handle(GetOrderingQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultOrderingDto>(value);
        }
    }
}
