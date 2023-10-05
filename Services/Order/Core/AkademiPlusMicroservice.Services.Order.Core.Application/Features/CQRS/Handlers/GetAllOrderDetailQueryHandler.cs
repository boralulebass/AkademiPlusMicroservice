using AutoMapper;
using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos;
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
    public class GetAllOrderDetailQueryHandler : IRequestHandler<GetAllOrderDetailQueryRequest, List<ResultOrderDetailDto>>
    {
        private readonly IRepository<Domain.Entities.OrderDetail> _repository;
        private readonly IMapper _mapper;

        public GetAllOrderDetailQueryHandler(IRepository<Domain.Entities.OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultOrderDetailDto>> Handle(GetAllOrderDetailQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<List<ResultOrderDetailDto>>(values);
        }
    }
}
