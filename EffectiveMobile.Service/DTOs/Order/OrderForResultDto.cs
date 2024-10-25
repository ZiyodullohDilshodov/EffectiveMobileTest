using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.DTOs.Order
{
    public  class OrderForResultDto
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public string DeliveryTime { get; set; }

        public long RegionId { get; set; }
        public long DeliveryLocationId { get; set; }
    }
}
