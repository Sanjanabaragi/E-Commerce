using ECommerce.Domain.Common;
using ECommerce.Domain.Enums;

namespace ECommerce.Domain.Entities;

public class Shipment : AuditableEntity
{
    public int OrderId { get; set; }

    public Order Order { get; set; } = null!;

    public string CourierName { get; set; } = string.Empty;

    public string TrackingNumber { get; set; } = string.Empty;

    public ShipmentStatus Status { get; set; }
        = ShipmentStatus.Pending;

    public DateTime? ShippedDate { get; set; }

    public DateTime? DeliveredDate { get; set; }
}