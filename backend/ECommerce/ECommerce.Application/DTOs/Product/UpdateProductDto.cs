namespace ECommerce.Application.DTOs.Product;

public class UpdateProductDto
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }

    public string SKU { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;
}