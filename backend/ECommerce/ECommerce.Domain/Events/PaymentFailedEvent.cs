namespace ECommerce.Domain.Events;

public class PaymentFailedEvent
{
    public int PaymentId { get; set; }

    public int OrderId { get; set; }

    public string Reason { get; set; } = string.Empty;

    public DateTime FailedAt { get; set; }
}