using POSSystem.Model;
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

namespace POSSystem.View
{
    /// <summary>
    /// Interaction logic for InventoryWindow.xaml
    /// </summary>
    public partial class InventoryWindow : Window
    {

        UserDbContext context = new UserDbContext();
        

        public InventoryWindow()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AllInventory_Button_Click(object sender, RoutedEventArgs e)
        {
            SeeAllInventoryWindow s = new SeeAllInventoryWindow();
            s.Show();
            
        }

        private void AddItem_Button_Click(object sender, RoutedEventArgs e)
        {
            AddItemWindow addItem = new AddItemWindow();
            addItem.Show();
        }
    }
}
