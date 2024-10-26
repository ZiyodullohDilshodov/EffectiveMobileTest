using EffectiveMobile.Data.DbContexts;
using EffectiveMobile.Data.IRepositories;
using EffectiveMobile.Domain.Entities;

namespace EffectiveMobile.Data.Repositories
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        public RegionRepository(EffectiveMobileDbContext effectiveMobileDbContext) : base(effectiveMobileDbContext)
        {
        }
    }
}
