using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos;
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
    public class GetOrderDetailQueryHandler : IRequestHandler<GetOrderDetailQueryRequest, ResultOrderDetailDto>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<AkademiPlusMicroservice.Services.Order.Core.Domain.Entities.OrderDetail> _repository;

        public GetOrderDetailQueryHandler(IMapper mapper, IRepository<AkademiPlusMicroservice.Services.Order.Core.Domain.Entities.OrderDetail> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ResultOrderDetailDto> Handle(GetOrderDetailQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultOrderDetailDto>(value);
        }
    }
}
