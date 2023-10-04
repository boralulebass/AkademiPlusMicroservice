namespace AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos
{
    public class UpdateOrderDetailDto
    {
        public int OrderDetailId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public int OrderingId { get; set; }
    }
}