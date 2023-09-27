using AkademiPlusMicroservice.Discount.Dtos;
using AkademiPlusMicroservice.Shared.Dtos;
using AutoMapper;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AkademiPlusMicroservice.Discount.Services
{
    public class DiscountCouponService : IDiscountCouponService
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IDbConnection _dbConnection;

        public DiscountCouponService(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
            _dbConnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }
        public async Task<Response<NoContent>> CreateDiscountCoupon(CreateDiscountCouponDto createDiscountCouponDto)
        {
            var status = await _dbConnection.ExecuteAsync("insert into DiscountCoupons (UserId,Rate,Code,CreatedDate) Values (@UserId,@Rate,@Code,@CreatedDate)", createDiscountCouponDto);

            if (status > 0)
            {
                return Response<NoContent>.Success(204);
            }
            return Response<NoContent>.Fail("Ekleme yapılırken bir hata oluştu", 500);
        }

        public async Task<Response<NoContent>> DeleteDiscountCoupon(int id)
        {
            var status = await _dbConnection.ExecuteAsync("delete from DiscountCoupons where DiscountCouponID=@DiscountCouponId", new { DiscountCouponId = id });
            if (status > 0)
            {
                return Response<NoContent>.Success(204);
            }
            return Response<NoContent>.Fail("Silme işlemi yapılırken bir hata oluştu", 500);
        }

        public async Task<Response<List<ResultDiscountCouponDto>>> GetListAll()
        {
            var values = await _dbConnection.QueryAsync<ResultDiscountCouponDto>("select * from DiscountCoupons");

            return Response<List<ResultDiscountCouponDto>>.Success(_mapper.Map<List<ResultDiscountCouponDto>>(values), 200);

        }

        public async Task<Response<NoContent>> UpdateDiscountCoupon(UpdateDiscountCouponDto updateDiscountCouponDto)
        {
            string sql = "update DiscountCoupons set UserId=@UserId,Code=@Code,Rate=@Rate,CreatedDate=@CreatedDate where DiscountCouponId=@DiscountCouponId";

            var paramaters = new DynamicParameters();
            paramaters.Add("@DiscountCouponId", updateDiscountCouponDto.DiscountCouponId);
            paramaters.Add("@UserID", updateDiscountCouponDto.UserId);
            paramaters.Add("@Rate", updateDiscountCouponDto.Rate);
            paramaters.Add("@Code", updateDiscountCouponDto.Code);

            paramaters.Add("@CreatedDate", updateDiscountCouponDto.CreatedDate);

            await _dbConnection.ExecuteAsync(sql, paramaters);

            return Response<NoContent>.Success(200);
        }
    }
}
