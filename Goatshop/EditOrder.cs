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
    public partial class EditOrder : Form
    {
        private Order _Order;
        public String searchTermCustomer = null;
        public String searchTermProduct = null;

        public EditOrder(Order order)
        {
            InitializeComponent();

            _Order = order;

            if (_Order.OrderNumber != null)
            {
                groupBox1.Text = _Order.OrderNumber;
                textBoxOrderNumber.Text = _Order.OrderNumber;
                textBoxCreated.Text = _Order.Created.ToString();
                labelTitleCustomer.Text += ": " +_Order.Customer.FirstName + " " + _Order.Customer.LastName;
            }

            ShowCustomer();
            ShowProducts();
            ShowOrderRows();

        }

        // List all customers
        public void ShowCustomer()
        {

            var ListOffCustomers = (from customer in Settings.db.Customer
                                 select customer).ToList();

            if (searchTermCustomer != null)
            {
                var ListOffSearchTerms = (from customer in ListOffCustomers
                                          where (customer.FirstName.IndexOf(searchTermCustomer, StringComparison.OrdinalIgnoreCase) >= 0 && checkBoxFirstname.Checked == true) ||
                                          (customer.LastName.IndexOf(searchTermCustomer, StringComparison.OrdinalIgnoreCase) >= 0 && checkBoxLastname.Checked == true)
                                          select customer).ToList();

                ListOffCustomers = ListOffSearchTerms;
            }


            listViewCustomer.Items.Clear();

            foreach (Customer customer in ListOffCustomers)
            {
                ListViewItem customerList = new ListViewItem();

                // setup the data for a list.
                customerList.Text = (customer.FirstName);
                customerList.SubItems.Add(customer.LastName);
                customerList.Tag = customer.ID;
                // add them to the list.
                listViewCustomer.Items.Add(customerList);
            }
        }

        // On text changed update the search term for customers
        private void textBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchCustomer.Text == "")
            {
                searchTermCustomer = null;
            }
            else if (checkBoxFirstname.Checked == false && checkBoxLastname.Checked == false)
            {
                searchTermCustomer = null;
            }
            else
            {
                searchTermCustomer = textBoxSearchCustomer.Text;
            }

            ShowCustomer();
        }

        // Reset the searchterm
        private void buttonResetSearchCustomer_Click(object sender, EventArgs e)
        {
            searchTermCustomer = null;
            textBoxSearchCustomer.Text = "";

            ShowCustomer();
        }



        // List all products
        public void ShowProducts()
        {

            listViewProduct.Items.Clear();


            var ListOffProducts = (from product in Settings.db.Product
                                   where  product.Deleted == null
                                   select product).ToList();



            if (searchTermProduct != null)
            {
                var ListOffSearchTerms = (from product in ListOffProducts
                                          where (product.Name.IndexOf(searchTermProduct, StringComparison.OrdinalIgnoreCase) >= 0 && checkBoxProductName.Checked == true) ||
                                          (product.Description.IndexOf(searchTermProduct, StringComparison.OrdinalIgnoreCase) >= 0 && checkBoxProductDescription.Checked == true) ||
                                           (product.Category.Category1.IndexOf(searchTermProduct, StringComparison.OrdinalIgnoreCase) >= 0 && checkBoxCategory.Checked == true)
                                          select product).ToList();

                ListOffProducts = ListOffSearchTerms;
            }



            foreach (Product product in ListOffProducts)
            {
                ListViewItem productList = new ListViewItem();

                // setup the data for a list.
                productList.Text = (product.Name);
                productList.SubItems.Add(product.Description);
                productList.SubItems.Add(product.Price.ToString());
                productList.SubItems.Add(product.AmountInStock.ToString());
                productList.SubItems.Add(product.Category.Category1);
                productList.SubItems.Add(product.Supplier.Name);
                productList.Tag = product.ID;
                // add them to the list.
                listViewProduct.Items.Add(productList);
            }

        }

        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchProduct.Text == "")
            {
                searchTermProduct = null;
            }
            else if (checkBoxProductName.Checked == false && checkBoxProductDescription.Checked == false && checkBoxCategory.Checked == false)
            {
                searchTermProduct = null;
            }
            else
            {
                searchTermProduct = textBoxSearchProduct.Text;
            }

            ShowProducts();
        }

        private void buttonResetSearchProduct_Click(object sender, EventArgs e)
        {
            searchTermProduct = null;
            textBoxSearchProduct.Text = "";

            ShowProducts();
        }



        // Show all products from the specific order.
        public void ShowOrderRows()
        {
            listViewOrder.Items.Clear();

            var ListOffOrderRows = (from orderRow in Settings.db.OrderRow
                                    where orderRow.Order_ID == _Order.ID
                                    select orderRow).ToList();


            foreach (OrderRow orderRow in ListOffOrderRows)
            {
                Decimal totalPrice = 0;
                totalPrice += (orderRow.Price * orderRow.Amount);

                ListViewItem orderList = new ListViewItem();

                // setup the data for a list.
                orderList.Text = (orderRow.Product.Name);
                orderList.SubItems.Add(orderRow.Product.Description);
                orderList.SubItems.Add(orderRow.Amount.ToString());
                orderList.SubItems.Add(orderRow.Price.ToString());
                orderList.SubItems.Add(totalPrice.ToString());
                orderList.Tag = orderRow.Product.ID;


                // add them to the list.
                listViewOrder.Items.Add(orderList);
            }
        }


        // return to last page
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // update or create the object and save it in the database.
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            // check if its a new record.
            if (_Order.OrderNumber == null)
            {
                Settings.db.Order.Add(_Order);
            }

            // Set the new value's
            _Order.OrderNumber = textBoxOrderNumber.Text;
            _Order.Created = DateTime.Today;

            // Check if there is a customer selected
            if (listViewCustomer.SelectedItems.Count > 0)
            {
                // Connect the relation - table with customer
                Customer selectedCustomer = Settings.db.Customer.Find(listViewCustomer.SelectedItems[0].Tag);
                _Order.Customer = selectedCustomer;

            }


            // Check it the name and the price is set higher than 0.
            if (_Order.OrderNumber != "" && _Order.Customer != null)
            {
                Settings.db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("The Name cant be empty and the price needs to be higher than 0", "ERROR");
            }
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            if (_Order.OrderNumber != "" && _Order.Customer != null)
            {
                OrderRow newOrderRow = new OrderRow();

                newOrderRow.Order = _Order;

                Product selectedProduct = Settings.db.Product.Find(listViewProduct.SelectedItems[0].Tag);
                newOrderRow.Product = selectedProduct;

                newOrderRow.Price = selectedProduct.Price.GetValueOrDefault();
                newOrderRow.Amount = (int)numericQuantity.Value;

                Settings.db.OrderRow.Add(newOrderRow);
                Settings.db.SaveChanges();

                ShowOrderRows();
            }
        }
    }
}
