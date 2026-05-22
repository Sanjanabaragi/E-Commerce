<<<<<<< HEAD
﻿using ECommerce.Domain.Common;
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
=======
namespace ECommerce.Domain.Entities
{
    public class InventoryReservation
    {
        public Guid ReservationId { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public Product? Product { get; set; }
    }
>>>>>>> 32f70ec9b4d5b870d53105c106a1cdfdcb23146c
}