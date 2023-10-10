using AkademiPlusMicroservice.Cargo.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Cargo.DataAccessLayer.Abstract
{
    public interface ICargoDetailDal : IGenericDal<CargoDetail>
    {
        int TotalCargoCount();
    }
}
