using ECommerce.Application.Interfaces.External;
using ECommerce.Application.Interfaces.Repositories;
using ECommerce.Application.Interfaces.Services;
using ECommerce.Application.Services;
using ECommerce.Infrastructure.Identities;
using ECommerce.Infrastructure.Repositories;
using ECommerce.Infrastructure.Repository;

namespace ECommerce.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection
        RegisterApplicationServices(
            this IServiceCollection services)
        {
            // Services
            services.AddScoped<IAuthService, AuthService>();

            // Repositories
            services.AddScoped<IUserRepository, UserRepository>();

            // Identity
            services.AddScoped<IPasswordHasher, PasswordHasher>();

            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<
                IJwtTokenGenerator,
                JwtTokenGenerator>();

            return services;
        }
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}