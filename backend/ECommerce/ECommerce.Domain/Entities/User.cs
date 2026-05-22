using ECommerce.Domain.Common;
using ECommerce.Domain.Enums;
using System.Net;

namespace ECommerce.Domain.Entities;

public class User : AuditableEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public UserRole Role { get; set; } = UserRole.Customer;

    public bool IsActive { get; set; } = true;

    public ICollection<Address> Addresses { get; set; }
        = new List<Address>();

    public ICollection<Order> Orders { get; set; }
        = new List<Order>();

    public ICollection<Cart> Carts { get; set; }
        = new List<Cart>();

    public ICollection<Notification> Notifications { get; set; }
        = new List<Notification>();
}