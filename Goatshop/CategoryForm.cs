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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            ShowList();
        }

        public void ShowList()
        {
            foreach (Category category in Settings.db.Category)
            {
                ListViewItem categoryList = new ListViewItem();

                // setup the data for a list.
                categoryList.Text = (category.Category1);
                categoryList.SubItems.Add(category.Description);
                categoryList.Tag = category.ID;
                // add them to the list.
                listViewCategory.Items.Add(categoryList);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
