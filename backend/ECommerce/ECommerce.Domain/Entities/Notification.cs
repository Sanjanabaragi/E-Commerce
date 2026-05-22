using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class Notification : AuditableEntity
{
    public int UserId { get; set; }

    public User User { get; set; } = null!;

    public string Type { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;

    public bool IsSent { get; set; } = false;

    public DateTime? SentAt { get; set; }
}