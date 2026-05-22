namespace ECommerce.Application.DTOs.Product
{
    public class CreateProductDto
    {
        public Guid CategoryId { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }
    }
}