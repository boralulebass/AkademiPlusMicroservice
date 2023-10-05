using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos;
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
    public class CreateOrderingCommandHandler : IRequestHandler<CreateOrderingCommandRequest, CreateOrderingDto>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public CreateOrderingCommandHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreateOrderingDto> Handle(CreateOrderingCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new Ordering
            {
                OrderDate = request.OrderDate,
                TotalPrice = request.TotalPrice,
                UserId = request.UserId
            };

            var result = await _repository.CreateAsync(values);
            return _mapper.Map<CreateOrderingDto>(result);
        }
    }
}
