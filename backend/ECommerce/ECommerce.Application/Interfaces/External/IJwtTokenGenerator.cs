using ECommerce.Domain.Entities;

namespace ECommerce.Application.Interfaces.External;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}