using Microsoft.EntityFrameworkCore;
using ECommerce.Application.DTOs.Product;
using ECommerce.Application.Interfaces.Services;
using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Persistence;

namespace ECommerce.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET ALL
        public async Task<List<ProductDto>> GetAllAsync()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .ToListAsync();

            return products.Select(p => new ProductDto
            {
                ProductId = p.ProductId,
                CategoryId = p.CategoryId,
                Name = p.Name,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                CategoryName = p.Category != null ? p.Category.Name : null
            }).ToList();
        }

        // GET BY ID
        public async Task<ProductDto?> GetByIdAsync(Guid productId)
        {
            var p = await _context.Products
                .Include(x => x.Category)
                .FirstOrDefaultAsync(x => x.ProductId == productId);

            if (p == null) return null;

            return new ProductDto
            {
                ProductId = p.ProductId,
                CategoryId = p.CategoryId,
                Name = p.Name,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                CategoryName = p.Category?.Name
            };
        }

        // CREATE
        public async Task<ProductDto> CreateAsync(CreateProductDto dto)
        {
            var product = new Product
            {
                ProductId = Guid.NewGuid(),
                CategoryId = dto.CategoryId,
                Name = dto.Name,
                Price = dto.Price,
                StockQuantity = dto.StockQuantity
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return new ProductDto
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                Name = product.Name,
                Price = product.Price,
                StockQuantity = product.StockQuantity
            };
        }

        // UPDATE
        public async Task<ProductDto?> UpdateAsync(Guid productId, UpdateProductDto dto)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null) return null;

            product.CategoryId = dto.CategoryId;
            product.Name = dto.Name;
            product.Price = dto.Price;
            product.StockQuantity = dto.StockQuantity;

            await _context.SaveChangesAsync();

            return new ProductDto
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                Name = product.Name,
                Price = product.Price,
                StockQuantity = product.StockQuantity
            };
        }

        // DELETE
        public async Task<bool> DeleteAsync(Guid productId)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null) return false;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}