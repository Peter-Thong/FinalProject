using ConsumeWcf.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ConsumeWcf
{
    /// <summary>
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        private MainWindow _mainWindow;

        //connect to the service
        Service1Client client = new Service1Client();

        private List<int> CustomerIDs;
        private List<int> OrderIDs;
        public OrderWindow(MainWindow win)
        {
            _mainWindow = win;
            InitializeComponent();

            CustomerIDs = (from cus in client.GetCustomers()
                      select cus.CustomerID).ToList();

            OrderIDs = (from or in client.GetOrders()
                           select or.OrderID).ToList();

            //bind data to datagrid
            dataGrid.ItemsSource = client.GetOrders();

            //sort data by order date
            ICollectionView dataView = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource);
            dataView.SortDescriptions.Clear();
            dataView.SortDescriptions.Add(new SortDescription("OrderDate", ListSortDirection.Descending));
            dataView.Refresh();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _mainWindow.Visibility = Visibility.Visible;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DateTime orderDate;
            DateTime filledDate;


            //checking error for inserting
            if (tbCustomerID.Text == "" || tbOrderDate.Text == "" ||
               tbFilledDate.Text == "" || tbStatus.Text == "" || tbAmount.Text == "")
            {
                MessageBox.Show("No text box can be empty", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!int.TryParse(tbCustomerID.Text, out int check) || !int.TryParse(tbAmount.Text, out int checks))
            {
                MessageBox.Show("customer ID and amount have to be integer type", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!CustomerIDs.Contains(int.Parse(tbCustomerID.Text)))
            {
                MessageBox.Show("invalid customer ID ", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (tbStatus.Text.Length > 1)
            {
                MessageBox.Show("status have to be exact 1 character", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!DateTime.TryParse(tbOrderDate.Text, out orderDate) || !DateTime.TryParse(tbFilledDate.Text, out filledDate))
            {
                MessageBox.Show("Date is not formated", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (DateTime.Compare(filledDate, orderDate) < 0)
            {
                MessageBox.Show("filled Date cannot be before order Date", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to add order?", "adding...", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        client.AddOrder(int.Parse(tbCustomerID.Text), orderDate, filledDate, tbStatus.Text, int.Parse(tbAmount.Text));
                        dataGrid.ItemsSource = client.GetOrders();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Date string not valid", "Error",
                                        MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
            }
        }

        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count == 1)
            {
                Order order = new Order();
                order = dataGrid.SelectedItem as Order;
                tbCustomerID.Text = order.CustomerID.ToString();
                tbOrderDate.SelectedDate = order.OrderDate;
                tbFilledDate.SelectedDate = order.FilledDate;
                tbStatus.Text = order.Status;
                tbAmount.Text = order.Amount.ToString();
            }
        }

            private void btnUpdate_Click(object sender, RoutedEventArgs e)
            {
            DateTime orderDate;
            DateTime filledDate;

            //checking error for updating
            if (tbCustomerID.Text == "" || tbOrderDate.Text == "" ||
               tbFilledDate.Text == "" || tbStatus.Text == "" || tbAmount.Text == "")
            {
                MessageBox.Show("No text box can be empty", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!int.TryParse(tbCustomerID.Text, out int check) || !int.TryParse(tbAmount.Text, out int checks))
            {
                MessageBox.Show("customer ID and amount have to be integer type", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!CustomerIDs.Contains(int.Parse(tbCustomerID.Text)))
            {
                MessageBox.Show("invalid customer ID ", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (tbStatus.Text.Length > 1)
            {
                MessageBox.Show("status have to be exact 1 character", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!DateTime.TryParse(tbOrderDate.Text, out orderDate) || !DateTime.TryParse(tbFilledDate.Text, out filledDate))
            {
                MessageBox.Show("Date is not formated", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (DateTime.Compare(filledDate, orderDate) < 0)
            {
                MessageBox.Show("filled Date cannot be before order Date", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

                var result = MessageBox.Show("Are you sure you want to update order?", "updating...", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    if (dataGrid.SelectedItems.Count == 1)
                    {
                        Order order = new Order();
                        order = dataGrid.SelectedItem as Order;

                        client.UpdateOrder(order.OrderID
                            , int.Parse(tbCustomerID.Text), orderDate, filledDate, tbStatus.Text, int.Parse(tbAmount.Text));

                        //update the view
                        dataGrid.ItemsSource = client.GetOrders();

                    } else
                    {
                        MessageBox.Show("No item selected", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                   
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {


            var result = MessageBox.Show("Are you sure you want to delete customer?", "deleting...", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                if (dataGrid.SelectedItems.Count == 1)
                {
                    Order order = new Order();
                    order = dataGrid.SelectedItem as Order;

                    client.DeleteOrder(order.OrderID);

                    //update the view
                    dataGrid.ItemsSource = client.GetOrders();
                    tbCustomerID.Text = "";
                    tbOrderDate.SelectedDate = DateTime.Now;
                    tbFilledDate.SelectedDate = DateTime.Now;
                    tbStatus.Text = "";
                    tbAmount.Text = "";
                }
                else
                {
                    MessageBox.Show("No item selected", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbSearch.Text, out int check))
            {
                MessageBox.Show("order ID and amount have to be integer type", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!OrderIDs.Contains(int.Parse(tbSearch.Text)))
            {
                MessageBox.Show("invalid order ID ", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int id = int.Parse(tbSearch.Text);
                Order order = client.GetOrderById(id);

                //update the view
                for(int i =0; i < OrderIDs.Count; i++)
                {
                    if(OrderIDs[i] == id)
                    {
                        var item = dataGrid.Items[i];
                        dataGrid.SelectedItem = item;
                        break;
                    }
                }
                tbCustomerID.Text = order.CustomerID.ToString();
                tbOrderDate.SelectedDate = order.OrderDate;
                tbFilledDate.SelectedDate = order.FilledDate;
                tbStatus.Text = order.Status;
                tbAmount.Text = order.Amount.ToString();
            }
        }
    }
}
