using AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Commands;
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
    public class RemoveOrderingCommandHandler : IRequestHandler<RemoveOrderingCommandRequest>
    {
        private readonly IRepository<Ordering> _repository;

        public RemoveOrderingCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveOrderingCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);

        }
    }
}
