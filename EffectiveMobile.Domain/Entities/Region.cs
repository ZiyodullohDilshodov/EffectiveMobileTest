using EffectiveMobile.Domain.Commons;

namespace EffectiveMobile.Domain.Entities
{
    public  class Region : Auditable
    {
        public string Name { get; set; }
        public long NumberOfOrders {  get; set; }
    }
}
