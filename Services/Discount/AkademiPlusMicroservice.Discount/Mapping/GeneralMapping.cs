using AkademiPlusMicroservice.Discount.Dtos;
using AkademiPlusMicroservice.Discount.Models;
using AutoMapper;

namespace AkademiPlusMicroservice.Discount.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<DiscountCoupon,ResultDiscountCouponDto>().ReverseMap();
            CreateMap<DiscountCoupon,CreateDiscountCouponDto>().ReverseMap();
            CreateMap<DiscountCoupon,UpdateDiscountCouponDto>().ReverseMap();
        }
    }
}
