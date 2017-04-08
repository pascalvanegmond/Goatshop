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
    public partial class EditSupplier : Form
    {
        private Supplier _Supplier;

        // Set All old value's in the textboxes
        public EditSupplier( Supplier supplier)
        {
            InitializeComponent();

            _Supplier = supplier;

            groupBox1.Text = _Supplier.Name;

            textBoxSupplier.Text = _Supplier.Name;
            textBoxDescription.Text = _Supplier.Description;
            textBoxAddress.Text = _Supplier.Adress;

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
            if (_Supplier.Name == null)
            {
                Settings.db.Supplier.Add(_Supplier);
            }

            _Supplier.Name = textBoxSupplier.Text;
            _Supplier.Description = textBoxDescription.Text;
            _Supplier.Adress = textBoxAddress.Text;

            // Check it the category is provided because the category cant be null.
            if (_Supplier.Name != "" && _Supplier.Adress != "")
            {
                Settings.db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Name and the Address cant be empty", "ERROR");
            }
        }
    }
}
