using ECommerce.Domain.Common;
using ECommerce.Domain.Enums;

namespace ECommerce.Domain.Entities;

public class InventoryReservation : AuditableEntity
{
    public int ProductId { get; set; }

    public Product Product { get; set; } = null!;

    public int Quantity { get; set; }

    public DateTime ReservedUntil { get; set; }

    public ReservationStatus Status { get; set; }
        = ReservationStatus.Active;
}