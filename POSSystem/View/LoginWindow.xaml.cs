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
using POSSystem;
using POSSystem.Model;

namespace POSSystem.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        UserDbContext context = new UserDbContext();


        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User u = null;
            foreach (var user in context.Users)
            {
                if (usernameTextBox.Text == user.Username.Trim() && passwordBox.Password.ToString() == user.Password.Trim())
                {

                    u = user;
                }

            }
            if (u != null)
            {
                wrongAuthMesaage.Content = "";
                POSSystemMainWindow posSystemMainWindow = new POSSystemMainWindow(); //u);
                posSystemMainWindow.Show();
                this.Close();

            }
            else
            {
                wrongAuthMesaage.Content = "Username and password are not matched, please enter again";

            }

        }
    }
}
