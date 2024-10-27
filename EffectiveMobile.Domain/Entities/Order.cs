using EffectiveMobile.Domain.Commons;

namespace EffectiveMobile.Domain.Entities
{
    public  class Order : Auditable
    {
        public  double  Weight { get; set; }
        public string Address { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public  DateTime DeliveryTime {  get; set; }
        public bool IsDeleted { get; set; } = false;

        public long RegionId { get; set; }
        public Region Region { get; set; }
       
    }
}
