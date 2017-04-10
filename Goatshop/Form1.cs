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
    public partial class GoatShop : Form
    {
        public GoatShop()
        {
            InitializeComponent();
            ShowLatestOrders();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();

        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm supplierform = new SupplierForm();
            supplierform.Show();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        public void ShowLatestOrders()
        {
            listViewOrder.Items.Clear();


            var ListOffOrders = (from order in Settings.db.Order
                                 orderby order.Created descending
                                 select order).ToList();

            foreach (Order order in ListOffOrders)
            {
                ListViewItem orderList = new ListViewItem();

                // Calculate the total order price
                Decimal totalPrice = 0;
                int totalProducts = 0;
                if (order.OrderRow.Count > 0)
                {
                    foreach (OrderRow item in order.OrderRow)
                    {
                        totalProducts += item.Amount;
                        totalPrice += (item.Price * item.Amount);
                    }
                }

                // setup the data for a list.
                orderList.Text = (order.OrderNumber);
                orderList.SubItems.Add(order.Customer.FirstName + " " + order.Customer.LastName);
                orderList.SubItems.Add(totalProducts.ToString());
                orderList.SubItems.Add(totalPrice.ToString());
                orderList.SubItems.Add(order.Created.ToString());
                orderList.Tag = order.ID;
                // add them to the list.
                listViewOrder.Items.Add(orderList);
            }

        }
    }
}
