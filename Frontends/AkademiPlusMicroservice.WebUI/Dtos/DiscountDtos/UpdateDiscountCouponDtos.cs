namespace AkademiPlusMicroservice.WebUI.Dtos
{
    public class UpdateDiscountCouponDtos
    {
        public Data[] data { get; set; }

        public class Data
        {
            public int DiscountCouponId { get; set; }
            public string UserId { get; set; }
            public int Rate { get; set; }
            public string Code { get; set; }
            public DateTime CreatedDate { get; set; }
        }
    }
}
