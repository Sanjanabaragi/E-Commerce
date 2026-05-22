using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class Role : BaseEntity
{
    public string Name { get; set; } = string.Empty;
}