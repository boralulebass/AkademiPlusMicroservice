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
    public class EfCargoStateDal : GenericRepository<CargoState>, ICargoStateDal
    {
        public EfCargoStateDal(CargoContext context) : base(context)
        {
        }
    }
}
