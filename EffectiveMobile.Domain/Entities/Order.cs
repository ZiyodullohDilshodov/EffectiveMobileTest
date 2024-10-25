using EffectiveMobile.Domain.Commons;

namespace EffectiveMobile.Domain.Entities
{
    public  class Order : Auditable
    {
        public  double  Weight { get; set; }
        public  string DeliveryTime {  get; set; }
        public bool IsDeleted { get; set; } = false;
        
        public long RegionId { get; set; }
        public Region Region { get; set; }

        public long DeliveryLocationId {  get; set; }
        public DeliveryLocation DeliveryLocation { get; set; }

    }
}
