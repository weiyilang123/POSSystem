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
    /// Interaction logic for UpdateItemWindow.xaml
    /// </summary>
    public partial class UpdateItemWindow : Window
    {

        UserDbContext context = new UserDbContext();
        Inventory item = null;

        public UpdateItemWindow()
        {
            InitializeComponent();
        }

        private void UpdateItem_Button_Click(object sender, RoutedEventArgs e)
        {
            if (item == null)
            {
                MessageBox.Show("No item found yet. Please find an item first.");
            }
            else
            {
                if(nameTextBox.Text != item.ItemName.Trim().ToString() || priceTextBox.Text != item.ItemPrice.Trim().ToString()
                    || stockTextBox.Text != item.ItemStockNumber.Trim().ToString() || DescriptionTextBox.Text != item.ItemDescription.Trim().ToString())
                {

                    MessageBoxResult dialogResult = MessageBox.Show("Are you sure about updating the item?", "Update This Item", MessageBoxButton.YesNo);
                    if (dialogResult == MessageBoxResult.Yes)
                    {
                        item.ItemName = nameTextBox.Text;
                        item.ItemPrice = priceTextBox.Text;
                        item.ItemStockNumber = stockTextBox.Text;
                        item.ItemDescription = DescriptionTextBox.Text;
                        context.Update(item);
                        context.SaveChanges();
                        MessageBox.Show("save successful");
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
                else
                {
                    MessageBox.Show("No changes has been made. Please change some value to update.");
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
