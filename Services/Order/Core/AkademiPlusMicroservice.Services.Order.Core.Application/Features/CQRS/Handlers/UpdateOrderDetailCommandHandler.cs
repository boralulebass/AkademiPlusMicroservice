using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos;
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
    public class UpdateOrderDetailCommandHandler : IRequestHandler<UpdateOrderDetailCommandRequest, UpdateOrderDetailDto>
    {
        private readonly IRepository<AkademiPlusMicroservice.Services.Order.Core.Domain.Entities.OrderDetail> _repository;
        private readonly IMapper _mapper;

    public UpdateOrderDetailCommandHandler(IRepository<AkademiPlusMicroservice.Services.Order.Core.Domain.Entities.OrderDetail> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<UpdateOrderDetailDto> Handle(UpdateOrderDetailCommandRequest request, CancellationToken cancellationToken)
    {
        var value = new AkademiPlusMicroservice.Services.Order.Core.Domain.Entities.OrderDetail
        {
            OrderDetailId = request.OrderDetailId,
            OrderingId = request.OrderingId,
            ProductAmount = request.ProductAmount,
            ProductId = request.ProductId,
            ProductName = request.ProductName,
            ProductPrice = request.ProductPrice
        };
        await _repository.UpdateAsync(value);
        return _mapper.Map<UpdateOrderDetailDto>(value);
    }
}
}
