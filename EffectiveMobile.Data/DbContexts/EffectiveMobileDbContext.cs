using EffectiveMobile.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EffectiveMobile.Data.DbContexts
{
    public  class EffectiveMobileDbContext : DbContext
    {
        public EffectiveMobileDbContext(DbContextOptions<EffectiveMobileDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Oreders { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<DeliveryLocation> DeliveryLocations { get; set; }

    }
}
