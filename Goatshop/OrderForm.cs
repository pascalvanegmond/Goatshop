using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goatshop
{
    public partial class OrderForm : Form
    {
        public String searchTerm = null;

        public OrderForm()
        {
            InitializeComponent();
            ShowList();
        }

        // Show all categories
        public void ShowList()
        {
            listViewOrder.Items.Clear();


            var ListOffOrders = (from order in Settings.db.Order
                                   select order).ToList();


            if (searchTerm != null)
            {
                Console.WriteLine(searchTerm);
                var ListOffSearchTerms = (from order in ListOffOrders
                                          where (order.OrderNumber.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 && checkBoxOrderNumber.Checked == true)||
                                          (order.Customer.FirstName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 && checkBoxCustomer.Checked == true)
                                          select order).ToList();

                ListOffOrders = ListOffSearchTerms;
            }


            foreach (Order order in ListOffOrders)
            {
                ListViewItem orderList = new ListViewItem();

                // Calculate the total order price
                Decimal totalPrice = 0;
                if (order.OrderRow.Count > 0)
                {
                    foreach (OrderRow item in order.OrderRow)
                    {
                       totalPrice += (item.Price * item.Amount);
                    }
                }

                // setup the data for a list.
                orderList.Text = (order.OrderNumber);
                orderList.SubItems.Add(order.Customer.FirstName + " " + order.Customer.LastName);
                orderList.SubItems.Add(order.OrderRow.Count.ToString());
                orderList.SubItems.Add(totalPrice.ToString());
                orderList.SubItems.Add(order.Created.ToString());
                orderList.Tag = order.ID;
                // add them to the list.
                listViewOrder.Items.Add(orderList);
            }
        }


        // Return to previous page
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Method to reload the page
        private void Reload_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowList();
        }

        // Get your selected category
        public Order SelectedOrder()
        {
            var OrderID = listViewOrder.SelectedItems[0].Tag;

            Order SelectedOrder = Settings.db.Order.Find(OrderID);

            return SelectedOrder;
        }

        // Open edit form
        public void OpenEditForm(Order order)
        {
            //EditProduct editProduct = new EditProduct(order);

            //editProduct.FormClosed += Reload_FormClosed;
            //editProduct.Show();
        }


        // ======================  CRUD  =========================================

        // Create
        private void buttonNew_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();

            OpenEditForm(newOrder);
        }

        // Update
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count > 0)
            {
                OpenEditForm(SelectedOrder());
            }
            else
            {
                MessageBox.Show("Nothing selected", "Info");
            }
        }


        // Delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count > 0)
            {
                if (SelectedOrder().OrderRow.Count == 0)
                {

                    Settings.db.Order.Remove(SelectedOrder());
                    Settings.db.SaveChanges();

                    ShowList();
                }
                else
                {
                    MessageBox.Show("Sorry you cant delete an Order with attached products. \nPlease remove the products from the order first.\n\nTry again after changing", "Error!");
                }
            }
            else
            {
                MessageBox.Show("Nothing selected", "Info");
            }
        }



        // Search
        private void buttonSearch_Click(object sender, EventArgs e)
        {

            if (textBoxSearch.Text == "")
            {
                searchTerm = null;
            }
            else if (checkBoxOrderNumber.Checked == false && checkBoxCustomer.Checked == false)
            {
                searchTerm = null;
            }
            else
            {
                searchTerm = textBoxSearch.Text;
            }

            ShowList();
        }

        // Reset the searchterm
        private void buttonResetSearch_Click(object sender, EventArgs e)
        {
            searchTerm = null;
            textBoxSearch.Text = "";

            ShowList();
        }
    }
}
