using ECommerce.Domain.Common;
using ECommerce.Domain.Enums;

namespace ECommerce.Domain.Entities;

public class Payment : AuditableEntity
{
    public int OrderId { get; set; }

    public Order Order { get; set; } = null!;

    public decimal Amount { get; set; }

    public string PaymentMethod { get; set; } = string.Empty;

    public string TransactionId { get; set; } = string.Empty;

    public PaymentStatus Status { get; set; }
        = PaymentStatus.Pending;
}