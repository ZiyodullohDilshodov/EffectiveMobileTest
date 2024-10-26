namespace EffectiveMobile.Service.DTOs.Order
{
    public  class OrderForUpdateDto
    {
        public double Weight { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string Address { get; set; }
        public long RegionId { get; set; }
      
    }
}
