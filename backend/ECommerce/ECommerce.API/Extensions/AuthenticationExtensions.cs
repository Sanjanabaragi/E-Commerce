using ECommerce.Infrastructure.Identities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ECommerce.API.Extensions;

public static class AuthenticationExtensions
{
    public static IServiceCollection
        AddJwtAuthentication(
            this IServiceCollection services,
            IConfiguration configuration)
    {
        var jwtSettings =
            configuration
                .GetSection("JwtSettings")
                .Get<JwtSettings>();

        services.Configure<JwtSettings>(
            configuration.GetSection("JwtSettings"));

        services
            .AddAuthentication(
                JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters =
                    new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,

                        ValidIssuer =
                            jwtSettings!.Issuer,

                        ValidAudience =
                            jwtSettings.Audience,

                        IssuerSigningKey =
                            new SymmetricSecurityKey(
                                Encoding.UTF8.GetBytes(
                                    jwtSettings.Secret))
                    };
            });

        return services;
    }
}