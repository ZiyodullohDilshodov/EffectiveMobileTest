using EffectiveMobile.Data.IRepositories;
using EffectiveMobile.Data.Repositories;
using EffectiveMobile.Service.Interfaces;
using EffectiveMobile.Service.Services;

namespace EffectiveMobileTest.Web.Api.Extension
{
    public static  class ServiceExtention
    {
        public static void AddCustomerService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderService>();

            services.AddScoped<IRegionService, RegionService>();
            services.AddScoped<IRegionRepository, RegionRepository>();
        }
    }
}
