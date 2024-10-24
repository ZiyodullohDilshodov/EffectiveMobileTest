using EffectiveMobile.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Domain.Entities
{
    public  class Region :Auditable
    {
        public string Name { get; set; }
        public long NumberOfOrders {  get; set; }
    }
}
