namespace ECommerce.Domain.Events;

public class PaymentSuccessEvent
{
    public int PaymentId { get; set; }

    public int OrderId { get; set; }

    public decimal Amount { get; set; }

    public DateTime PaidAt { get; set; }
}