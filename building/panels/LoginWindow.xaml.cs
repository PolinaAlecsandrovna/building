using building.Models;
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
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            using var db = new AppDbContext();

            var user = db.AppUsers.FirstOrDefault(u => u.Login == LoginBox.Text.Trim() && u.Password == PasswordBox.Password);

            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль.","Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            new ProductsWindow(user).Show();
            Close();
        }
        private void Guest_Click(object sender, RoutedEventArgs e)
        {
            new ProductsWindow(null).Show();
            Close();
        }
    }
}
