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
    public partial class ProductForm : Form
    {
        public static Boolean showDeleted = false;

        public ProductForm()
        {
            InitializeComponent();
            ShowList();
        }

        // Show all categories
        public void ShowList()
        {
            listViewProduct.Items.Clear();


            var ListOffProducts = (from product in Settings.db.Product
                                   where product.Deleted == null && showDeleted == false ||
                                   product.Deleted != null && showDeleted == true
                                    select product).ToList();
            
            

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

        private void buttonShowDeleted_Click(object sender, EventArgs e)
        {
            if (buttonShowDeleted.Text == "Show deleted products")
            {
                labelDeleted.Text = "Showing deleted items";
                buttonShowDeleted.Text = "Show current products";
                showDeleted = true;
            }
            else if (buttonShowDeleted.Text == "Show current products")
            {
                labelDeleted.Text = "";
                buttonShowDeleted.Text = "Show deleted products";
                showDeleted = false;
            }

            ShowList();
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
        public Product SelectedProduct()
        {
            var ProductID = listViewProduct.SelectedItems[0].Tag;

            Product SelectedProduct = Settings.db.Product.Find(ProductID);

            return SelectedProduct;
        }

        // Open edit form
        public void OpenEditForm(Product product)
        {
            //EditSupplier editProduct = new EditSupplier(product);

            //editProduct.FormClosed += Reload_FormClosed;
            //editProduct.Show();
        }


        // ======================  CRUD  =========================================

        // Create
        private void buttonNew_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();

            OpenEditForm(newProduct);
        }

        // Update
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count > 0)
            {
                OpenEditForm(SelectedProduct());
            }
        }


        // Delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (SelectedProduct().OrderRow.Count == 0)
            {

                SelectedProduct().Deleted = DateTime.Now;
                  
                //Settings.db.Product.Remove(SelectedProduct());
                Settings.db.SaveChanges();

                ShowList();
            }
            else
            {
                MessageBox.Show("Sorry you cant delete a Product with attached orders. \nPlease remove or change those products first.\n\nTry again after changing", "Error!");
            }
        }

    }
}
