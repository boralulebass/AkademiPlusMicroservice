namespace AkademiPlusMicroservice.Services.Order.Core.Application.Dtos.AddressDtos
{
    public class ResultAddressDto
    {
        public int AddressId { get; set; }
        public string UserId { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Detail { get; set; }
    }
}
