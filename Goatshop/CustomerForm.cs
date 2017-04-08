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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            ShowList();
        }

        // Show all categories
        public void ShowList()
        {
            listViewCustomer.Items.Clear();

            foreach (Customer customer in Settings.db.Customer)
            {
                ListViewItem customerList = new ListViewItem();

                // setup the data for a list.
                customerList.Text = (customer.FirstName);
                customerList.SubItems.Add(customer.LastName);
                customerList.SubItems.Add(customer.Adress);
                customerList.SubItems.Add(customer.Birthday.ToString());
                customerList.Tag = customer.ID;
                // add them to the list.
                listViewCustomer.Items.Add(customerList);
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
        public Customer SelectedCustomer()
        {
            var CustomerID = listViewCustomer.SelectedItems[0].Tag;

            Customer selectedCustomer = Settings.db.Customer.Find(CustomerID);

            return selectedCustomer;
        }

        // Open edit form
        public void OpenEditForm(Customer customer)
        {
            EditCustomer editCustomer = new EditCustomer(customer);

            editCustomer.FormClosed += Reload_FormClosed;
            editCustomer.Show();
        }


        // ======================  CRUD  =========================================

        // Create
        private void buttonNew_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();

            OpenEditForm(newCustomer);
        }

        // Update
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCustomer.SelectedItems.Count > 0)
            {
                OpenEditForm(SelectedCustomer());
            }
        }


        // Delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (SelectedCustomer().Order.Count == 0)
            {
                Settings.db.Customer.Remove(SelectedCustomer());
                Settings.db.SaveChanges();

                ShowList();
            }
            else
            {
                MessageBox.Show("Sorry you cant delete a Customer who has orders. \nPlease remove those orders first.\n\nTry again after changing", "Error!");
            }
        }
    }
}
