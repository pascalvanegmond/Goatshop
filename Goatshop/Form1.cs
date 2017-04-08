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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Plotdata()
        {
           
            foreach (Product product in Settings.db.Product)
            {
                textBox1.Text += product.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plotdata();
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
    }
}
