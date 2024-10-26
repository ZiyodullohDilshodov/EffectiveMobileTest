namespace EffectiveMobile.Service.DTOs.Order
{
    public  class OrderForCreationDto
    {
        public string Address { get; set; }
        public double Weight { get; set; }
        public long RegionId { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
    }
}
