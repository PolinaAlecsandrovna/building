using building.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace building.panels
{
    /// <summary>
    /// Логика взаимодействия для ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        public ProductsWindow(AppUser? user)
        {
            InitializeComponent();

            UserText.Text = user?.FullName ?? "Гость";
            LoadProducts();
        }

        private void LoadProducts()
        {
            using var db = new AppDbContext();

            var products = db.Products
                .Include(p => p.Category)
                .Include(p => p.Manufacturer)
                .Include(p => p.Unit)
                .OrderBy(p => p.Name)
                .ToList();

            ProductsList.ItemsSource = products.Select(p => new ProductRow
            {
                Name = p.Name,
                Category = p.Category.Name,
                Manufacturer = p.Manufacturer.Name,
                Price = p.Price,
                Unit = p.Unit.ShortName,
                Stock = p.StockQuantity,
                DiscountPercent = p.DiscountPercent,
                FinalPrice = Math.Round(p.Price * (1 -  p.DiscountPercent / 100m), 2)
            }).ToList();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            new LoginWindow().Show();
            Close();
        }
    }
    public class ProductRow
    {
        public string Name { get; set; } = "";
        public string Category { get; set; } = "";
        public string Manufacturer { get; set; } = "";
        public decimal Price { get; set; }
        public string Unit { get; set; } = "";
        public int Stock { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal FinalPrice { get; set; }
        public bool HasBigDiscount => DiscountPercent > 15;
    }
}
