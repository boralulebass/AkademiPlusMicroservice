using AkademiPlusMicroservice.Basket.Dtos;
using AkademiPlusMicroservice.Shared.Dtos;

namespace AkademiPlusMicroservice.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userId);
        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
        Task<Response<bool>> DeleteBasket(string userId);
    }
}
