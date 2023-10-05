using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetOrderDetailQueryRequest : IRequest<ResultOrderDetailDto>
    {
        public GetOrderDetailQueryRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
