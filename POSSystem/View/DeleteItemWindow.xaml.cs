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
    /// Interaction logic for DeleteItemWindow.xaml
    /// </summary>
    public partial class DeleteItemWindow : Window
    {
        UserDbContext context = new UserDbContext();
        Inventory item = null;
        public DeleteItemWindow()
        {
            InitializeComponent();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if(item == null)
            {
                MessageBox.Show("No item found yet. Please find an item first.");
            }
            else
            {
                MessageBoxResult dialogResult = MessageBox.Show("Are you sure about deleting the item?", "Delete This Item", MessageBoxButton.YesNo);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    context.Inventorys.Remove(item);
                    context.SaveChanges();
                    MessageBox.Show("Delete succesful.");
                    nameTextBox.Text = "";
                    priceTextBox.Text = "";
                    stockTextBox.Text = "";
                    DescriptionTextBox.Text = "";
                    EANTextBox.Text = "";
                }
                else if (dialogResult == MessageBoxResult.No)
                {
                    
                }
                
            }
        }

        private void FindItem_Button_Click(object sender, RoutedEventArgs e)
        {
            if (EANTextBox.Text != "")
            {
                item = context.Inventorys.Where(i => i.ItemEANNumber.Trim().ToString() == EANTextBox.Text).FirstOrDefault();
                if (item == null)
                {
                    MessageBox.Show("No item found");
                }
                else
                {
                    nameTextBox.Text = item.ItemName;
                    priceTextBox.Text = item.ItemPrice;
                    stockTextBox.Text = item.ItemStockNumber;
                    DescriptionTextBox.Text = item.ItemDescription;
                }
               
            }
            else
            {
                MessageBox.Show("Please enter EAN Code.");
            }
        }
    }
}
