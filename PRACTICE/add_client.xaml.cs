using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Data.SqlClient;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PRACTICE
{
    /// <summary>
    /// Логика взаимодействия для add_client.xaml
    /// </summary>
    public partial class add_client : Window
    {

        public add_client()
        {
            InitializeComponent();

        }
       

            private void Confirm_click(object sender, RoutedEventArgs e)
        {
           CustomerManager customerManager = new CustomerManager();
            customerManager.RegisterCustomer(Text_Login.Text,Text_Password.Password);

        }

        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void TextPassword(object sender, TextChangedEventArgs e)
        {
           
        }


    }
}
