using AkademiPlusMicroservice.Cargo.BusinessLayer.Abstract;
using AkademiPlusMicroservice.Cargo.DataAccessLayer.Abstract;
using AkademiPlusMicroservice.Cargo.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Cargo.BusinessLayer.Concrete
{
    public class CargoDetailManager : ICargoDetailService
    {
        private readonly ICargoDetailDal _cargoDetailDal;

        public CargoDetailManager(ICargoDetailDal cargoDetailDal)
        {
            _cargoDetailDal = cargoDetailDal;
        }

        public async Task TCreateAsync(CargoDetail entity)
        {
            await _cargoDetailDal.CreateAsync(entity);
        }

        public async Task TDeleteAsync(CargoDetail entity)
        {
            await _cargoDetailDal.DeleteAsync(entity);
        }

        public async Task<List<CargoDetail>> TGetAllAsync()
        {
            return await _cargoDetailDal.GetAllAsync();
        }

        public async Task<CargoDetail> TGetByIdAsync(int id)
        {
            return await _cargoDetailDal.GetByIdAsync(id);
        }

        public async Task TUpdateAsync(CargoDetail entity)
        {
            await _cargoDetailDal.UpdateAsync(entity);
        }
    }
}
