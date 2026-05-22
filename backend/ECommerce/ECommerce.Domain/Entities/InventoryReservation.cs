namespace ECommerce.Domain.Entities
{
    public class InventoryReservation
    {
        public Guid ReservationId { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public Product? Product { get; set; }
    }
}