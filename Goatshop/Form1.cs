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
            //PersonEditForm personEditForm = new PersonEditForm(selectedPerson);
            //personEditForm.FormClosed += Reload_FormClosed;
            //personEditForm.Show();
        }
    }
}
