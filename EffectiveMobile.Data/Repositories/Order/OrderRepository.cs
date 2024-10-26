using EffectiveMobile.Data.DbContexts;
using EffectiveMobile.Data.IRepositories;
using EffectiveMobile.Domain.Entities;

namespace EffectiveMobile.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(EffectiveMobileDbContext effectiveMobileDbContext) : base(effectiveMobileDbContext)
        {
        }
    }
}
