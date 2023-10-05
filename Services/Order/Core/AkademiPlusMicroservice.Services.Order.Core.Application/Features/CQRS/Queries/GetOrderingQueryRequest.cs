using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderingDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetOrderingQueryRequest: IRequest<ResultOrderingDto>
    {
        public GetOrderingQueryRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
