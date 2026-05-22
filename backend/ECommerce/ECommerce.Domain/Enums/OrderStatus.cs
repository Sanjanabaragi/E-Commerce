namespace ECommerce.Domain.Enums;

public enum OrderStatus
{
    Pending = 1,
    Reserved = 2,
    Paid = 3,
    Processing = 4,
    Packed = 5,
    Shipped = 6,
    Delivered = 7,
    Completed = 8,
    Cancelled = 9,
    Failed = 10
}