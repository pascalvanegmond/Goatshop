﻿using System;
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
    public partial class EditCategory : Form
    {
        private Category _Category;

        // Set All old value's in the textboxes
        public EditCategory( Category category)
        {
            InitializeComponent();

            _Category = category;

            groupBox1.Text = _Category.Category1;

            textBoxCategory.Text = _Category.Category1;
            textBoxDescription.Text = _Category.Description;
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
            if (_Category.Category1 == null)
            {
                Settings.db.Category.Add(_Category);
            }

            _Category.Category1 = textBoxCategory.Text;
            _Category.Description = textBoxDescription.Text;

            // Check it the category is provided because the category cant be null.
            if (_Category.Category1 != "")
            {
                Settings.db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Category cant be empty", "ERROR");
            }

            
        }
    }
}
