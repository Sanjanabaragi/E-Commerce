namespace ECommerce.Domain.Events;

public class OrderShippedEvent
{
    public int OrderId { get; set; }

    public string TrackingNumber { get; set; } = string.Empty;

    public string CourierName { get; set; } = string.Empty;

    public DateTime ShippedAt { get; set; }
}