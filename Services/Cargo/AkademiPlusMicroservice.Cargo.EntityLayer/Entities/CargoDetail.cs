using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Cargo.EntityLayer.Entities
{
    public class CargoDetail
    {
        public int CargoDetailId { get; set; }
        public int OrderingId { get; set; }
        public int CargoStateId { get; set; }
        public CargoState CargoState { get; set; }
    }
}
