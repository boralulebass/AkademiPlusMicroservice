using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Commands
{
    public class RemoveAddressCommandRequest : IRequest
    {
        public RemoveAddressCommandRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }


    }
}
