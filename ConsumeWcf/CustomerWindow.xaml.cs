using ConsumeWcf.ServiceReference1;
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

namespace ConsumeWcf
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private MainWindow _mainWindow;

        //connect to the service
        Service1Client client = new Service1Client();
        private List<int> CustomerIDs;

        public CustomerWindow(MainWindow win)
        {
            _mainWindow = win;
            InitializeComponent();
            CustomerIDs = (from cus in client.GetCustomers()
                           select cus.CustomerID).ToList();
            lstCustomer.DataContext = CustomerIDs;

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            _mainWindow.Visibility = Visibility.Visible;


        }

        private void lstCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstCustomer.SelectedItem != null)
            {
                int i = (int)lstCustomer.SelectedItem;
                Customer selectedCustomer = client.GetCustomerById(i);

                tbName.Text = selectedCustomer.CustomerName;
                tbYTDOrders.Text = selectedCustomer.YTDOrders.ToString();
                tbYTDSales.Text = selectedCustomer.YTDSales.ToString();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //checking error for inserting
            if (tbName.Text == "" || tbYTDOrders.Text == "" ||
               tbYTDSales.Text == "")
            {
                MessageBox.Show("No text box can be empty", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!int.TryParse(tbYTDOrders.Text, out int check) || !int.TryParse(tbYTDSales.Text, out int checks))
            {
                MessageBox.Show("YTDOrders and YTDSales have to be integer type", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (tbName.Text.Length >= 40)
            {
                MessageBox.Show("Name cannot be longer than 40 character", "Error",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to add customer?", "adding...", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    client.AddCustomer(tbName.Text, int.Parse(tbYTDOrders.Text), int.Parse(tbYTDSales.Text));

                    //update the views
                    var ids = from cus in client.GetCustomers()
                              select cus.CustomerID;
                    lstCustomer.DataContext = ids;
                }
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //checking error for updating
            if (lstCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("No item is selected", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (tbName.Text == "" || tbYTDOrders.Text == "" ||
               tbYTDSales.Text == "")
            {
                MessageBox.Show("No text box can be empty", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!int.TryParse(tbYTDOrders.Text, out int check) || !int.TryParse(tbYTDSales.Text, out int checks))
            {
                MessageBox.Show("YTDOrders and YTDSales have to be integer type", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (tbName.Text.Length >= 40)
            {
                MessageBox.Show("Name cannot be longer than 40 character", "Error",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

                var result = MessageBox.Show("Are you sure you want to update customer?", "updating...", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    int i = (int)lstCustomer.SelectedItem;

                    client.UpdateCustomer(i, tbName.Text, int.Parse(tbYTDOrders.Text), int.Parse(tbYTDSales.Text));

                    //update the views
                    var ids = from cus in client.GetCustomers()
                              select cus.CustomerID;
                    lstCustomer.DataContext = ids;
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (lstCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("No item is selected", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

                var result = MessageBox.Show("Are you sure you want to delete customer?", "deleting...", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    int i = (int)lstCustomer.SelectedItem;
                    client.DeleteCustomer(i);

                    var ids = from cus in client.GetCustomers()
                              select cus.CustomerID;

                    lstCustomer.DataContext = ids;

                    //update the views
                    tbName.Text = "";
                    tbYTDOrders.Text = "";
                    tbYTDSales.Text = "";
                }
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if(!int.TryParse(tbSearch.Text, out int check))
            {
                MessageBox.Show("customer ID and amount have to be integer type", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!CustomerIDs.Contains(int.Parse(tbSearch.Text)))
            {
                MessageBox.Show("invalid customer ID ", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int id = int.Parse(tbSearch.Text);
                Customer selectedCustomer = client.GetCustomerById(id);

                //update the views
                lstCustomer.SelectedIndex = CustomerIDs.IndexOf(id);
                tbName.Text = selectedCustomer.CustomerName;
                tbYTDOrders.Text = selectedCustomer.YTDOrders.ToString();
                tbYTDSales.Text = selectedCustomer.YTDSales.ToString();
            }
        }
    }
}
