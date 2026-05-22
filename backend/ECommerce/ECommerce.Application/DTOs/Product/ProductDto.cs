namespace ECommerce.Application.DTOs.Product
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }

        public Guid CategoryId { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        // Optional (for UI display)
        public string? CategoryName { get; set; }
    }
}