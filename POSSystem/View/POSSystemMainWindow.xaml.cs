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
using POSSystem.Model;

namespace POSSystem.View
{
    /// <summary>
    /// Interaction logic for POSSystemMainWindow.xaml
    /// </summary>
    public partial class POSSystemMainWindow : Window
    {
        User currentUser = new User()
        {
            Id = 1,
            Username = "test",
            Password = "1234",
            UserType = "Manager",
            Name = "Random Name"

        };
        public POSSystemMainWindow()
        {
            InitializeComponent();
            //currentUser = user;
            nameLabel.Content = "Current User: " + currentUser.Name.Trim();
            userTypeLabel.Content = "User Limits: " + currentUser.UserType.Trim();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Signout_Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private void Inventory_Button_Click(object sender, RoutedEventArgs e)
        {
            if(currentUser.UserType.Trim() == "Manager")
            {
                InventoryWindow iw = new InventoryWindow();
                iw.Show();

            }
            else
            {
                MessageBox.Show("You are not authorized to access Inventory");
            }
        }

        private void Cashier_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
