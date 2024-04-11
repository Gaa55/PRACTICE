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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRACTICE
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerManager customerManager=new CustomerManager();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void New_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            string login=LoginBox.Text;
            string password=PasswordBox.Text;

            if (customerManager.CheckCredentials(login,password))
            { Window2 window2 = new Window2();
                window2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Поошел нахууй!!!");
            }
=======
            
>>>>>>> 203e2318c27a1185b86f94555dd990049903ffa3
        }
        private void Registration_click(object sender, RoutedEventArgs e)
        { add_client Add_Client=new add_client();
            Add_Client.Show();
            this.Close();
        }
    }
}
