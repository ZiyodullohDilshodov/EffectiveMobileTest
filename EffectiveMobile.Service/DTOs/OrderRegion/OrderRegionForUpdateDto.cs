using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.DTOs.OrderRegion
{
    public  class OrderRegionForUpdateDto
    {
        public long RegionId { get; set; }
        public long OrderId { get; set; }
        public long DeliveryLocationId { get; set; }
    }
}
