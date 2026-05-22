using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class Address : AuditableEntity
{
    public string FullName { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Street { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string State { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

    public int UserId { get; set; }

    public User User { get; set; } = null!;
}