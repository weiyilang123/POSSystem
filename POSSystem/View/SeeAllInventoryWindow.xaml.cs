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

        
        List<Inventory> inventories = null;
        
        public SeeAllInventoryWindow()
        {
            InitializeComponent();

            showAllTheInventory();
           // inventoryListView.ItemsSource = inventories;
           
            
        }

        private void showAllTheInventory()
        {
            UserDbContext context = new UserDbContext();
            inventoryDataGrid.Items.Clear();
            inventories = new List<Inventory>();
            foreach (var inv in context.Inventorys)
            {
                inventories.Add(inv);
                inventoryDataGrid.Items.Add(inv);

            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            inventoryDataGrid.Items.Clear();
            foreach(var i in inventories)
            {
                if(i.ItemName.ToLower().Contains(searchTextBox.Text.ToLower()) || i.ItemPrice.Contains(searchTextBox.Text.ToLower()) ||
                    i.ItemStockNumber.ToLower().Contains(searchTextBox.Text.ToLower()) || i.ItemEANNumber.ToLower().Contains(searchTextBox.Text.ToLower()))
                {
                    inventoryDataGrid.Items.Add(i);
                }
            }
        }

        private void Refresh_Button_Click(object sender, RoutedEventArgs e)
        {
            showAllTheInventory();
            searchTextBox.Text = "";
        }
    }
}
