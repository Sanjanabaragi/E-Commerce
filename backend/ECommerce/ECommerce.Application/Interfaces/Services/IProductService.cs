using ECommerce.Application.DTOs.Product;

namespace ECommerce.Application.Interfaces.Services
{
    public interface IProductService
    {
        // GET all products
        Task<List<ProductDto>> GetAllAsync();

        // GET product by id
        Task<ProductDto?> GetByIdAsync(Guid productId);

        // CREATE product
        Task<ProductDto> CreateAsync(CreateProductDto dto);

        // UPDATE product
        Task<ProductDto?> UpdateAsync(Guid productId, UpdateProductDto dto);

        // DELETE product
        Task<bool> DeleteAsync(Guid productId);
    }
}