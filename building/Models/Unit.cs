using System;
using System.Collections.Generic;

namespace building.Models;

/// <summary>
/// Единицы измерения
/// </summary>
public partial class Unit
{
    public short UnitId { get; set; }

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
