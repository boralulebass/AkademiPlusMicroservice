using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos;
using AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Commands;
using AkademiPlusMicroservice.Services.Order.Core.Application.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommandRequest, CreateOrderDetailDto>
    {
        private readonly IRepository<Domain.Entities.OrderDetail> _repository;
        private readonly IMapper _mapper;

        public CreateOrderDetailCommandHandler(IRepository<Domain.Entities.OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreateOrderDetailDto> Handle(CreateOrderDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new Domain.Entities.OrderDetail
            {
                ProductPrice = request.ProductPrice,
                ProductAmount = request.ProductAmount,
                OrderingId = request.OrderingId,
                ProductId = request.ProductId,
                ProductName = request.ProductName,
            };
            var result = await _repository.CreateAsync(values);
            return _mapper.Map<CreateOrderDetailDto>(result);
        }
    }
}
