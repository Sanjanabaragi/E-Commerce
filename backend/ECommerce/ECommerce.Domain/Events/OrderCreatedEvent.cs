namespace ECommerce.Domain.Events;

public class OrderCreatedEvent
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public decimal TotalAmount { get; set; }

    public DateTime CreatedAt { get; set; }
}