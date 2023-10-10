using AkademiPlusMicroservice.Cargo.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Cargo.DataAccessLayer.Context
{
    public class CargoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433;database=AkademiPlusCargoDb;user=sa;password=123456Aa*;");
        }

        public DbSet<CargoDetail> CargoDetails { get; set; }
        public DbSet<CargoState> CargoStates { get; set; }

    }
}
