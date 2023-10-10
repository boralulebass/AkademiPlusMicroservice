namespace AkademiPlusMicroservice.Cargo.EntityLayer.Entities
{
    public class CargoState
    {
        public int CargoStateId { get; set; }
        public string Description { get; set; }
        public List<CargoDetail> CargoDetails { get; set; }
    }
}
