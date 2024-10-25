using EffectiveMobile.Domain.Commons;

namespace EffectiveMobile.Domain.Entities
{
    public  class DeliveryLocation : Auditable
    {
        public bool IsDeleted { get; set; }
        public decimal  Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string Address { get; set; } 

    }
}
