using System;
using System.Collections.Generic;

namespace building.Models;

/// <summary>
/// Производители товаров
/// </summary>
public partial class Manufacturer
{
    public short ManufacturerId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
