using EffectiveMobile.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Domain.Entities
{
    public  class OrderRegion : Auditable
    {
        public long RegionId {  get; set; }
        public Region Region { get; set; }

        public long OrderId { get; set; } 
        public Order Oreder { get; set; }

        public long DeliveryLocationId {  get; set; }
        public DeliveryLocation DeliveryLocation { get; set; }

    }
}
