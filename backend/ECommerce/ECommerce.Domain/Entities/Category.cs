<<<<<<< HEAD
﻿using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class Category : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public ICollection<Product> Products { get; set; }
        = new List<Product>();
=======
namespace ECommerce.Domain.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<Product>? Products { get; set; }
    }
>>>>>>> 32f70ec9b4d5b870d53105c106a1cdfdcb23146c
}