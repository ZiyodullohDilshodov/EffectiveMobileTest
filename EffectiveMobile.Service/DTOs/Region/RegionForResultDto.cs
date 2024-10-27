using EffectiveMobile.Service.DTOs.Order;

namespace EffectiveMobile.Service.DTOs.Region
{
    public  class RegionForResultDto
    {
        public long Id {  get; set; }
        public string Name { get; set; }
        public long NumberOfOrders { get; set; }
        public DateTime CreatedAtt { get; set; }

        public ICollection<OrderForResultDto> Orders { get; set; }
    }
}
