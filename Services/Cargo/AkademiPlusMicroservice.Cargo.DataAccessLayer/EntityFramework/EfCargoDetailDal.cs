using AkademiPlusMicroservice.Cargo.DataAccessLayer.Abstract;
using AkademiPlusMicroservice.Cargo.DataAccessLayer.Context;
using AkademiPlusMicroservice.Cargo.DataAccessLayer.Repositories;
using AkademiPlusMicroservice.Cargo.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoDetailDal : GenericRepository<CargoDetail>, ICargoDetailDal
    {
        private readonly CargoContext _context;
        public EfCargoDetailDal(CargoContext context) : base(context)
        {
            _context = context;
        }

        public int TotalCargoCount()
        {
            return _context.CargoDetails.Count();
        }
    }
}
