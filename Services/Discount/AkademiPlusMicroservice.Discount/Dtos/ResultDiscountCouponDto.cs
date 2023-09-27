namespace AkademiPlusMicroservice.Discount.Dtos
{
    public class ResultDiscountCouponDto
    {
        public int DiscountCouponId { get; set; }
        public string UserId { get; set; }
        public int Rate { get; set; }
        public string Code { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
