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
        { string filePath = "regisetredUsers.txt";
            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            using (StreamWriter writer = new StreamWriter(filePath, append: true)) 
            { writer.WriteLine($"{Text_Login.Text},{Text_Password.Text}"); }
          }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

      
    }
}
