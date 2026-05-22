namespace ECommerce.Domain.Enums;

public enum ShipmentStatus
{
    Pending = 1,
    Picked = 2,
    Packed = 3,
    Shipped = 4,
    InTransit = 5,
    OutForDelivery = 6,
    Delivered = 7,
    Failed = 8
}