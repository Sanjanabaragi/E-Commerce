<<<<<<< HEAD
<<<<<<< HEAD
﻿using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class Product : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }

    public string SKU { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;

    public ICollection<CartItem> CartItems { get; set; }
        = new List<CartItem>();

    public ICollection<OrderItem> OrderItems { get; set; }
        = new List<OrderItem>();

    public ICollection<InventoryReservation> Reservations { get; set; }
        = new List<InventoryReservation>();
=======
=======
>>>>>>> d158fb46215eb84ba0105cbec93efbc8b050b811
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
<<<<<<< HEAD
>>>>>>> 32f70ec9b4d5b870d53105c106a1cdfdcb23146c
=======
>>>>>>> d158fb46215eb84ba0105cbec93efbc8b050b811
}