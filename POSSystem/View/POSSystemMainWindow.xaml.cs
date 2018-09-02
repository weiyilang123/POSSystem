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
        public POSSystemMainWindow(User currentUser)
        {
            InitializeComponent();
            nameLabel.Content = "Current User: " + currentUser.Name.Trim();
            userTypeLabel.Content = "User Limits: " + currentUser.UserType.Trim();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
