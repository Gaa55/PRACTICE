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

namespace PRACTICE
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void KlientbI (object sender, RoutedEventArgs e)
        {
            using (var context = new ELECTRONICS_SHOPEntities3())
            {
                var customers = context.Customers.ToList();
                UserDataGrid.ItemsSource = customers;

            }
        }
        private void Prodyktsia(object sender, RoutedEventArgs e)
        {
            using (var context = new ELECTRONICS_SHOPEntities3())
            {
                var product = context.Product.ToList();
                UserDataGrid.ItemsSource = product;

            }
        }
        private void Manufacturies(object sender, RoutedEventArgs e)
        {
            using (var context = new ELECTRONICS_SHOPEntities3())
            {
                var manufacturers = context.Manufacturers.ToList();
                UserDataGrid.ItemsSource = manufacturers;

            }
        }
        private void Orders(object sender, RoutedEventArgs e)
        {
            using (var context = new ELECTRONICS_SHOPEntities3())
            {
                var orders = context.Orders.ToList();
                UserDataGrid.ItemsSource = orders;

            }
        }

    }
}
