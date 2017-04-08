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
    public partial class EditCustomer : Form
    {
        private Customer _Customer;

        // Set All old value's in the textboxes
        public EditCustomer(Customer customer)
        {
            InitializeComponent();

            _Customer = customer;

            groupBox1.Text += _Customer.FirstName + _Customer.LastName;

            textBoxFirstname.Text = _Customer.FirstName;
            textBoxLastname.Text = _Customer.LastName;
            dateTimePickerBirthday.Text = _Customer.Birthday.ToString();
            textBoxAddress.Text = _Customer.Adress;
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
            if (_Customer.FirstName == null)
            {
                Settings.db.Customer.Add(_Customer);
            }

            _Customer.FirstName = textBoxFirstname.Text;
            _Customer.LastName = textBoxLastname.Text;
            _Customer.Birthday = dateTimePickerBirthday.Value.Date;
            _Customer.Adress = textBoxAddress.Text;

            // Check it the category is provided because the category cant be null.
            if (_Customer.FirstName != "" && _Customer.Adress != "")
            {
                Settings.db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Firstname and the Address cant be empty", "ERROR");
            }
        }
    }
}
