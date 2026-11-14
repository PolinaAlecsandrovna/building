using System;
using System.Collections.Generic;

namespace building.Models;

/// <summary>
/// Поставщики товаров
/// </summary>
public partial class Supplier
{
    public short SupplierId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
