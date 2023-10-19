using AkademiPlusMicroservice.Discount.Dtos;
using AkademiPlusMicroservice.Discount.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.Discount.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountCouponsController : ControllerBase
    {
        private readonly IDiscountCouponService _discountCouponService;

        public DiscountCouponsController(IDiscountCouponService discountCouponService)
        {
            _discountCouponService = discountCouponService;
        }

        [HttpPost]

        public async Task<IActionResult> CreateDiscountCoupons(CreateDiscountCouponDto createDiscountCouponDto)
        {
            await _discountCouponService.CreateDiscountCoupon(createDiscountCouponDto);
            return Ok("Kupon oluşturuldu");
        }
        [HttpDelete]

        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountCouponService.DeleteDiscountCoupon(id);
            return Ok("Silme işlemi gerçekleşti");
        }

        [HttpGet]

        public async Task<IActionResult> GetAllDiscount()
        {
            var values = await _discountCouponService.GetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetDiscountById(int id)
        {
            var values = await _discountCouponService.GetDiscountById(id);
            return Ok(values);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto updateDiscountCouponDto)
        {
            await _discountCouponService.UpdateDiscountCoupon(updateDiscountCouponDto);
            return Ok("Güncelleme işlemi başarılı");
        }
    }
}
