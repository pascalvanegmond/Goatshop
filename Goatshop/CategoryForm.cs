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

        // Show all categories
        public void ShowList()
        {
            listViewCategory.Items.Clear();

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
        public Category SelectedCat()
        {
            var CategoryID = listViewCategory.SelectedItems[0].Tag;

            Category selectedCategory = Settings.db.Category.Find(CategoryID);

            return selectedCategory;
        }

        // Open edit form
        public void OpenEditForm(Category category)
        {
            EditCategory editCat = new EditCategory(category);

            editCat.FormClosed += Reload_FormClosed;
            editCat.Show();
        }


        // ======================  CRUD  =========================================

        // Create
        private void buttonNew_Click(object sender, EventArgs e)
        {
            Category newCat = new Category();
            Settings.db.Category.Add(newCat);

            OpenEditForm(newCat);

        }

        // Update
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCategory.SelectedItems.Count > 0)
            {
                OpenEditForm(SelectedCat());
            }

        }

        // Delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (SelectedCat().Product.Count == 0)
            {
                Settings.db.Category.Remove(SelectedCat());
                Settings.db.SaveChanges();

                ShowList();
            }
            else
            {
                MessageBox.Show("Sorry you cant delete a Category with attached products. \nPlease remove or change those products first.\n\nTry again after changing", "Error!");
            }
        }
    }
}
