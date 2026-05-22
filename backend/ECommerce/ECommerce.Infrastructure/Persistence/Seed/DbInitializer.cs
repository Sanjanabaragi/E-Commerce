using ECommerce.Domain.Entities;
using ECommerce.Domain.Enums;

namespace ECommerce.Infrastructure.Persistence.Seed;

public static class DbInitializer
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!context.Categories.Any())
        {
            var categories = new List<Category>
            {
                new()
                {
                    Name = "Men",
                    Description = "Men Fashion"
                },
                new()
                {
                    Name = "Women",
                    Description = "Women Fashion"
                },
                new()
                {
                    Name = "Shoes",
                    Description = "Footwear Collection"
                }
            };

            await context.Categories.AddRangeAsync(categories);
            await context.SaveChangesAsync();
        }

        if (!context.Users.Any())
        {
            var adminUser = new User
            {
                FirstName = "System",
                LastName = "Admin",
                Email = "admin@ecommerce.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin@123"),
                PhoneNumber = "9999999999",
                Role = UserRole.Admin,
                IsActive = true
            };

            await context.Users.AddAsync(adminUser);
            await context.SaveChangesAsync();
        }
    }
}