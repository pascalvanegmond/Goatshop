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
    public partial class EditCategory : Form
    {
        private Category _Category;
        public EditCategory( Category category)
        {
            InitializeComponent();

            _Category = category;

            groupBox1.Text = _Category.Category1;

            textBoxCategory.Text = _Category.Category1;
            textBoxDescription.Text = _Category.Description;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _Category.Category1 = textBoxCategory.Text;
            _Category.Description = textBoxDescription.Text;

            Settings.db.SaveChanges();

            Close();
        }
    }
}
