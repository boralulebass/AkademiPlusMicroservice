using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.AddressDtos;
using AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos;
using AkademiPlusMicroservice.Services.Order.Core.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Services.Order.Core.Application.Mapping
{
    public class OrderDetailProfile : Profile
    {
        public OrderDetailProfile()
        {
            CreateMap<ResultOrderDetailDto, OrderDetail>().ReverseMap();
            CreateMap<CreateOrderDetailDto, OrderDetail>().ReverseMap();
            CreateMap<UpdateOrderDetailDto, OrderDetail>().ReverseMap();
        }
    }
}
