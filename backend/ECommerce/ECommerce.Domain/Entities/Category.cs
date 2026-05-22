<<<<<<< HEAD
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
=======
>>>>>>> d158fb46215eb84ba0105cbec93efbc8b050b811
namespace ECommerce.Domain.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<Product>? Products { get; set; }
    }
<<<<<<< HEAD
>>>>>>> 32f70ec9b4d5b870d53105c106a1cdfdcb23146c
=======
>>>>>>> d158fb46215eb84ba0105cbec93efbc8b050b811
}