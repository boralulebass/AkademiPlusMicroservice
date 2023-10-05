using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Services.Order.Core.Application.Features.CQRS.Commands
{
    public class RemoveOrderingCommandRequest : IRequest
    {
        public RemoveOrderingCommandRequest(int ıd)
        {
            Id = ıd;
        }
        public  int Id { get; set; }




    }
}
