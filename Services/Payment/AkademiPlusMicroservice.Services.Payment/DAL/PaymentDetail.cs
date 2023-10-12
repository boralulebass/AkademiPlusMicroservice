namespace AkademiPlusMicroservice.Services.Payment.DAL
{
    public class PaymentDetail
    {
        public int PaymentDetailId { get; set; }
        public string CartNumber { get; set; }
        public string CustomerName { get; set;}
        public decimal TotalPrice { get; set; }
        public string PaymentType { get; set; }

    }
}
