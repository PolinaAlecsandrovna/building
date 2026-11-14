using System;
using System.Collections.Generic;

namespace building.Models;

/// <summary>
/// Товары магазина
/// </summary>
public partial class Product
{
    public long ProductId { get; set; }

    public string Name { get; set; } = null!;

    public short CategoryId { get; set; }

    public string? Description { get; set; }

    public short ManufacturerId { get; set; }

    public short SupplierId { get; set; }

    /// <summary>
    /// Цена за единицу, руб. (допускаются сотые части)
    /// </summary>
    public decimal Price { get; set; }

    public short UnitId { get; set; }

    public int StockQuantity { get; set; }

    /// <summary>
    /// Действующая скидка, % (0–100)
    /// </summary>
    public decimal DiscountPercent { get; set; }

    /// <summary>
    /// Относительный путь к файлу изображения; NULL — заглушка picture.png
    /// </summary>
    public string? ImagePath { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;

    public bool HasBigDiscount => DiscountPercent > 15;
}
