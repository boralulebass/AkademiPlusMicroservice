using Microsoft.EntityFrameworkCore;

namespace AkademiPlusMicroservice.Services.Payment.DAL.Context
{
    public class PaymentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433;database=AkademiPlusPaymentDb;user=sa;password=123456Aa*;");
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
