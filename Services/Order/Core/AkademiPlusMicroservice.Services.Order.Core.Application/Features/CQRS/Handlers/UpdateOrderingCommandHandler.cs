using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderingDtos;
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
    public class UpdateOrderingCommandHandler : IRequestHandler<UpdateOrderingCommandRequest, UpdateOrderingDto>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public UpdateOrderingCommandHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UpdateOrderingDto> Handle(UpdateOrderingCommandRequest request, CancellationToken cancellationToken)
        {
            var value = new Ordering
            {
                OrderDate = request.OrderDate,
                OrderingId = request.OrderingId,
                TotalPrice = request.TotalPrice,
                UserId = request.UserId
            };
            await _repository.UpdateAsync(value);
            return _mapper.Map<UpdateOrderingDto>(value);
        }
    }
}
