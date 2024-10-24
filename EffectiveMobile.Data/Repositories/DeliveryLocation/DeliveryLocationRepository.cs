using EffectiveMobile.Data.DbContexts;
using EffectiveMobile.Data.IRepositories;
using EffectiveMobile.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveMobile.Data.Repositories
{
    public class DeliveryLocationRepository : Repository<DeliveryLocation>, IDeliveryLocationRepository
    {
        public DeliveryLocationRepository(EffectiveMobileDbContext effectiveMobileDbContext) : base(effectiveMobileDbContext)
        {
        }
    }
}
