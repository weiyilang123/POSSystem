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
    /// Interaction logic for AddItemWindow.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {
        UserDbContext context = new UserDbContext();
        public AddItemWindow()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            if(nameTextBox.Text != "" && priceTextBox.Text != "" && stockTextBox.Text != "" && EANTextBox.Text != "")
            {
                Inventory inventory = new Inventory()
                {
                    ItemName = nameTextBox.Text,
                    ItemPrice = priceTextBox.Text,
                    ItemStockNumber = stockTextBox.Text,
                    ItemEANNumber = EANTextBox.Text,
                    ItemDescription = DescriptionTextBox.Text
                };
                context.Add<Inventory>(inventory);
                context.SaveChanges();
                MessageBox.Show("Data saved");
            }

            nameTextBox.Text = "";
            priceTextBox.Text = "";
            stockTextBox.Text = "";
            EANTextBox.Text = "";
            DescriptionTextBox.Text = "";
        }
    }
}
