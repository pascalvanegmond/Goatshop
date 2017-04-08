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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
            ShowList();
        }

        // Show all categories
        public void ShowList()
        {
            listViewSupplier.Items.Clear();

            foreach (Supplier supplier in Settings.db.Supplier)
            {
                ListViewItem supplierList = new ListViewItem();

                // setup the data for a list.
                supplierList.Text = (supplier.Name);
                supplierList.SubItems.Add(supplier.Description);
                supplierList.SubItems.Add(supplier.Adress);
                supplierList.Tag = supplier.ID;
                // add them to the list.
                listViewSupplier.Items.Add(supplierList);
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
        public Supplier SelectedSupp()
        {
            var SupplierID = listViewSupplier.SelectedItems[0].Tag;

            Supplier selectedSupplier = Settings.db.Supplier.Find(SupplierID);

            return selectedSupplier;
        }

        // Open edit form
        public void OpenEditForm(Supplier supplier)
        {
            EditSupplier editSupp = new EditSupplier(supplier);

            editSupp.FormClosed += Reload_FormClosed;
            editSupp.Show();
        }


        // ======================  CRUD  =========================================

        // Create
        private void buttonNew_Click(object sender, EventArgs e)
        {
            Supplier newSupp = new Supplier();

            OpenEditForm(newSupp);
        }

        // Update
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSupplier.SelectedItems.Count > 0)
            {
                OpenEditForm(SelectedSupp());
            }
        }


        // Delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (SelectedSupp().Product.Count == 0)
            {
                Settings.db.Supplier.Remove(SelectedSupp());
                Settings.db.SaveChanges();

                ShowList();
            }
            else
            {
                MessageBox.Show("Sorry you cant delete a Supplier with attached products. \nPlease remove or change those products first.\n\nTry again after changing", "Error!");
            }
        }


    }
}
