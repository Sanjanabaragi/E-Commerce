namespace ECommerce.Domain.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }

        // FK
        public Guid CategoryId { get; set; }

        // Properties
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        // Navigation Property (important for EF Core)
        public Category? Category { get; set; }

        // Inventory relation (1 product -> many reservations)
        public ICollection<InventoryReservation>? InventoryReservations { get; set; }
    }
}