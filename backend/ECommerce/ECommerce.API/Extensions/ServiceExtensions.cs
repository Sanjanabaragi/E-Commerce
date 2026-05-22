using ECommerce.Application.Interfaces.Services;
using ECommerce.Application.Services;

namespace ECommerce.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}