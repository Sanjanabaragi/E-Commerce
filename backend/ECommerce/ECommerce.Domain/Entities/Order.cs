using ECommerce.Domain.Common;
using ECommerce.Domain.Enums;

namespace ECommerce.Domain.Entities;

public class Order : AuditableEntity
{
    public int UserId { get; set; }

    public User User { get; set; } = null!;

    public decimal TotalAmount { get; set; }

    public OrderStatus Status { get; set; }
        = OrderStatus.Pending;

    public PaymentStatus PaymentStatus { get; set; }
        = PaymentStatus.Pending;

    public int ShippingAddressId { get; set; }

    public Address ShippingAddress { get; set; } = null!;

    public ICollection<OrderItem> OrderItems { get; set; }
        = new List<OrderItem>();

    public Payment? Payment { get; set; }

    public Shipment? Shipment { get; set; }
}