using EffectiveMobile.Service.DTOs.Region;

namespace EffectiveMobile.Service.DTOs.Order
{
    public  class OrderForResultDto
    {
        public long  Id { get; set; }
        public double Weight { get; set; }
        public DateTime DeliveryTime { get; set; }
        public long RegionId { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAtt { get; set; }

        public ICollection<RegionForResultDto> Locations { get; set; }
    }
}
