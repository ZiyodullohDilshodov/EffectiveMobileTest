﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Service.DTOs.DeliveryLocation
{
    public  class DeliveryLocationForResultDto
    {
        public long Id {  get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string Address { get; set; }
    }
}
