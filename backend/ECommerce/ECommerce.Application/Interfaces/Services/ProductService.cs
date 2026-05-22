using ECommerce.Application.DTOs.Product;
using ECommerce.Application.Interfaces.Repositories;
using ECommerce.Application.Interfaces.Services;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(
        IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    // GET ALL PRODUCTS
    public async Task<List<ProductDto>> GetAllAsync()
    {
        var products =
            await _productRepository.GetAllAsync();

        return products.Select(p => new ProductDto
        {
            ProductId = p.Id,
            CategoryId = p.CategoryId,
            Name = p.Name,
            Price = p.Price,
            StockQuantity = p.StockQuantity,
            CategoryName = p.Category?.Name
        }).ToList();
    }

    // GET PRODUCT BY ID
    public async Task<ProductDto?> GetByIdAsync(
        int productId)
    {
        var product =
            await _productRepository
                .GetByIdAsync(productId);

        if (product == null)
            return null;

        return new ProductDto
        {
            ProductId = product.Id,
            CategoryId = product.CategoryId,
            Name = product.Name,
            Price = product.Price,
            StockQuantity = product.StockQuantity,
            CategoryName = product.Category?.Name
        };
    }

    // CREATE PRODUCT
    public async Task<ProductDto> CreateAsync(
        CreateProductDto dto)
    {
        var product = new Product
        {
            CategoryId = dto.CategoryId,
            Name = dto.Name,
            Description = dto.Description,
            Price = dto.Price,
            StockQuantity = dto.StockQuantity,
            SKU = dto.SKU,
            ImageUrl = dto.ImageUrl
        };

        await _productRepository.AddAsync(product);

        await _productRepository.SaveChangesAsync();

        return new ProductDto
        {
            ProductId = product.Id,
            CategoryId = product.CategoryId,
            Name = product.Name,
            Price = product.Price,
            StockQuantity = product.StockQuantity
        };
    }

    // UPDATE PRODUCT
    public async Task<ProductDto?> UpdateAsync(
        int productId,
        UpdateProductDto dto)
    {
        var product =
            await _productRepository
                .GetByIdAsync(productId);

        if (product == null)
            return null;

        product.CategoryId = dto.CategoryId;
        product.Name = dto.Name;
        product.Description = dto.Description;
        product.Price = dto.Price;
        product.StockQuantity = dto.StockQuantity;
        product.SKU = dto.SKU;
        product.ImageUrl = dto.ImageUrl;

        await _productRepository.UpdateAsync(product);

        await _productRepository.SaveChangesAsync();

        return new ProductDto
        {
            ProductId = product.Id,
            CategoryId = product.CategoryId,
            Name = product.Name,
            Price = product.Price,
            StockQuantity = product.StockQuantity
        };
    }

    // DELETE PRODUCT
    public async Task<bool> DeleteAsync(
        int productId)
    {
        var product =
            await _productRepository
                .GetByIdAsync(productId);

        if (product == null)
            return false;

        await _productRepository.DeleteAsync(product);

        await _productRepository.SaveChangesAsync();

        return true;
    }
}