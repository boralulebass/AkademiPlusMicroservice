using AkademiPlusMicroservice.Discount.Dtos;
using AkademiPlusMicroservice.Shared.Dtos;

namespace AkademiPlusMicroservice.Discount.Services
{
    public interface IDiscountCouponService
    {
        Task<Response<List<ResultDiscountCouponDto>>> GetListAll();
        Task<Response<NoContent>> CreateDiscountCoupon(CreateDiscountCouponDto createDiscountCouponDto);
        Task<Response<NoContent>> UpdateDiscountCoupon(UpdateDiscountCouponDto updateDiscountCouponDto);
        Task<Response<NoContent>> DeleteDiscountCoupon(int id);
        Task<Response<GetDiscountCouponDtos>> GetDiscountById(int id);
    }
}
