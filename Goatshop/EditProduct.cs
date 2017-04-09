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
    public partial class EditProduct : Form
    {
        private Product _Product;

        public EditProduct(Product product)
        {
            InitializeComponent();

            _Product = product;

            // Fill the comboboxes
            Dictionary<int, string> Categories = new Dictionary<int, string>();
            foreach (Category category in Settings.db.Category)
            {
                Categories.Add(category.ID, category.Category1);

                comboBoxCategory.DataSource = new BindingSource(Categories, null);
                comboBoxCategory.ValueMember = "Key";
                comboBoxCategory.DisplayMember = "Value";
            }

            Dictionary<int, string> Suppliers = new Dictionary<int, string>();
            foreach (Supplier supplier in Settings.db.Supplier)
            {
                Suppliers.Add(supplier.ID, supplier.Name);

                comboBoxSupplier.DataSource = new BindingSource(Suppliers, null);
                comboBoxSupplier.ValueMember = "Key";
                comboBoxSupplier.DisplayMember = "Value";
            }

            // set the inputs if the object already exist in the db
            if (_Product.Name != null)
            {
                groupBox1.Text = _Product.Name;

                textBoxProductName.Text = _Product.Name;
                textBoxDescription.Text = _Product.Description;
                numericPrice.Text = _Product.Price.ToString();
                numericInStock.Text = _Product.AmountInStock.ToString();
                comboBoxCategory.Text = _Product.Category.Category1;
                comboBoxSupplier.Text = _Product.Supplier.Name;
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
            Decimal Dnumber;
            int Inumber;

            // check if its a new record.
            if (_Product.Name == null)
            {
                Settings.db.Product.Add(_Product);
            }

            // Set the new value's
            _Product.Name = textBoxProductName.Text;
            _Product.Description = textBoxDescription.Text;

            // TryParse Decimal
            if (Decimal.TryParse(numericPrice.Text, out Dnumber))
            {
                _Product.Price = Decimal.Parse(numericPrice.Text);
            }
            else
            {
                MessageBox.Show("The price must be a decimal", "ERROR");
            }

            // TryParse Int
            if (Int32.TryParse(numericInStock.Text, out Inumber))
            {
                _Product.AmountInStock = Int32.Parse(numericInStock.Text);
            }
            else
            {
                MessageBox.Show("The Stock value can only be a number", "ERROR");
            }

            // Connect the relation - table with category
            Category selectedCategory = Settings.db.Category.Find(comboBoxCategory.SelectedValue);
            _Product.Category = selectedCategory;

            // Connect the relation - table with supplier
            Supplier selectedSupplier = Settings.db.Supplier.Find(comboBoxSupplier.SelectedValue);
            _Product.Supplier = selectedSupplier;


            // Check it the name and the price is set higher than 0.
            if (_Product.Name != "" && _Product.Price > 0)
            {
                Settings.db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("The Name cant be empty and the price needs to be higher than 0", "ERROR");
            }
        }
    }
}
