using POSSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for SeeAllInventoryWindow.xaml
    /// </summary>
    public partial class SeeAllInventoryWindow : Window
    {

        UserDbContext context = new UserDbContext();
        List<Inventory> inventories = null;
        
        public SeeAllInventoryWindow()
        {
            InitializeComponent();
            inventories = new List<Inventory>();
            foreach(var inv in context.Inventorys)
            {
                inventories.Add(inv);
                inventoryListView.Items.Add(inv);
            }
            
           // inventoryListView.ItemsSource = inventories;
           
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            inventoryListView.Items.Clear();
            foreach(var i in inventories)
            {
                if(i.ItemName.ToLower().Contains(searchTextBox.Text.ToLower()) || i.ItemPrice.Contains(searchTextBox.Text.ToLower()) ||
                    i.ItemStockNumber.ToLower().Contains(searchTextBox.Text.ToLower()) || i.ItemEANNumber.ToLower().Contains(searchTextBox.Text.ToLower()))
                {
                    inventoryListView.Items.Add(i);
                }
            }
        }
    }
}
