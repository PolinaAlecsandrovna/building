using System;
using System.Collections.Generic;

namespace building.Models;

/// <summary>
/// Категории товаров
/// </summary>
public partial class Category
{
    public short CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
