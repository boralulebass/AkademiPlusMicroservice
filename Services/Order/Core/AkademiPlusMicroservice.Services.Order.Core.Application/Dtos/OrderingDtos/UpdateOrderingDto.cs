namespace AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderingDtos
{
    public class UpdateOrderingDto
    {
        public int OrderingId { get; set; }
        public string UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
