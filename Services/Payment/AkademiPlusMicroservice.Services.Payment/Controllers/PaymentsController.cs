using AkademiPlusMicroservice.Services.Payment.DAL;
using AkademiPlusMicroservice.Services.Payment.DAL.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.Services.Payment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly PaymentContext _paymentContext;

        public PaymentsController(PaymentContext paymentContext)
        {
            _paymentContext = paymentContext;
        }

        [HttpGet]
        public IActionResult PaymentList()
        {
            var values = _paymentContext.PaymentDetails.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult PaymentCreate(PaymentDetail paymentDetail)
        {
            _paymentContext.PaymentDetails.Add(paymentDetail);
            _paymentContext.SaveChanges();
            return Ok("Ödeme başarılı bir şekilde alındı");
        }
    }
}
