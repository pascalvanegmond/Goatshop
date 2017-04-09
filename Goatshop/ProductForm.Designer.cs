namespace Goatshop
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupplierHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonShowDeleted = new System.Windows.Forms.Button();
            this.labelDeleted = new System.Windows.Forms.Label();
            this.buttonRestoreDeleted = new System.Windows.Forms.Button();
            this.checkBoxProductName = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonResetSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(28, 109);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(28, 24);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(28, 154);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 9;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(28, 66);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // listViewProduct
            // 
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.DescriptionHeader,
            this.PriceHeader,
            this.StockHeader,
            this.CategoryHeader,
            this.SupplierHeader});
            this.listViewProduct.FullRowSelect = true;
            this.listViewProduct.GridLines = true;
            this.listViewProduct.Location = new System.Drawing.Point(19, 57);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(682, 357);
            this.listViewProduct.TabIndex = 18;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Product name";
            this.NameHeader.Width = 144;
            // 
            // DescriptionHeader
            // 
            this.DescriptionHeader.Text = "Description";
            this.DescriptionHeader.Width = 233;
            // 
            // PriceHeader
            // 
            this.PriceHeader.Text = "Price";
            this.PriceHeader.Width = 70;
            // 
            // StockHeader
            // 
            this.StockHeader.Text = "In Stock";
            this.StockHeader.Width = 53;
            // 
            // CategoryHeader
            // 
            this.CategoryHeader.Text = "Category";
            this.CategoryHeader.Width = 88;
            // 
            // SupplierHeader
            // 
            this.SupplierHeader.Text = "Supplier";
            this.SupplierHeader.Width = 89;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonReturn);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Location = new System.Drawing.Point(717, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 196);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(324, 42);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Products overview";
            // 
            // buttonShowDeleted
            // 
            this.buttonShowDeleted.Location = new System.Drawing.Point(19, 434);
            this.buttonShowDeleted.Name = "buttonShowDeleted";
            this.buttonShowDeleted.Size = new System.Drawing.Size(245, 42);
            this.buttonShowDeleted.TabIndex = 21;
            this.buttonShowDeleted.Text = "Show deleted products";
            this.buttonShowDeleted.UseVisualStyleBackColor = true;
            this.buttonShowDeleted.Click += new System.EventHandler(this.buttonShowDeleted_Click);
            // 
            // labelDeleted
            // 
            this.labelDeleted.AutoSize = true;
            this.labelDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleted.ForeColor = System.Drawing.Color.Red;
            this.labelDeleted.Location = new System.Drawing.Point(442, 21);
            this.labelDeleted.Name = "labelDeleted";
            this.labelDeleted.Size = new System.Drawing.Size(0, 29);
            this.labelDeleted.TabIndex = 19;
            // 
            // buttonRestoreDeleted
            // 
            this.buttonRestoreDeleted.Location = new System.Drawing.Point(283, 434);
            this.buttonRestoreDeleted.Name = "buttonRestoreDeleted";
            this.buttonRestoreDeleted.Size = new System.Drawing.Size(245, 42);
            this.buttonRestoreDeleted.TabIndex = 21;
            this.buttonRestoreDeleted.Text = "Restore deleted product";
            this.buttonRestoreDeleted.UseVisualStyleBackColor = true;
            this.buttonRestoreDeleted.Visible = false;
            this.buttonRestoreDeleted.Click += new System.EventHandler(this.buttonRestoreDeleted_Click);
            // 
            // checkBoxProductName
            // 
            this.checkBoxProductName.AutoSize = true;
            this.checkBoxProductName.Checked = true;
            this.checkBoxProductName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProductName.Location = new System.Drawing.Point(17, 47);
            this.checkBoxProductName.Name = "checkBoxProductName";
            this.checkBoxProductName.Size = new System.Drawing.Size(92, 17);
            this.checkBoxProductName.TabIndex = 22;
            this.checkBoxProductName.Text = "Product name";
            this.checkBoxProductName.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.checkBoxDescription);
            this.groupBox2.Controls.Add(this.buttonResetSearch);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.checkBoxProductName);
            this.groupBox2.Location = new System.Drawing.Point(717, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 162);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(17, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 23;
            // 
            // checkBoxDescription
            // 
            this.checkBoxDescription.AutoSize = true;
            this.checkBoxDescription.Location = new System.Drawing.Point(17, 70);
            this.checkBoxDescription.Name = "checkBoxDescription";
            this.checkBoxDescription.Size = new System.Drawing.Size(79, 17);
            this.checkBoxDescription.TabIndex = 22;
            this.checkBoxDescription.Text = "Description";
            this.checkBoxDescription.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(17, 99);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search!";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonResetSearch
            // 
            this.buttonResetSearch.Location = new System.Drawing.Point(17, 129);
            this.buttonResetSearch.Name = "buttonResetSearch";
            this.buttonResetSearch.Size = new System.Drawing.Size(100, 23);
            this.buttonResetSearch.TabIndex = 6;
            this.buttonResetSearch.Text = "Reset";
            this.buttonResetSearch.UseVisualStyleBackColor = true;
            this.buttonResetSearch.Click += new System.EventHandler(this.buttonResetSearch_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonRestoreDeleted);
            this.Controls.Add(this.buttonShowDeleted);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDeleted);
            this.Controls.Add(this.labelTitle);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader DescriptionHeader;
        private System.Windows.Forms.ColumnHeader PriceHeader;
        private System.Windows.Forms.ColumnHeader StockHeader;
        private System.Windows.Forms.ColumnHeader CategoryHeader;
        private System.Windows.Forms.ColumnHeader SupplierHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonShowDeleted;
        private System.Windows.Forms.Label labelDeleted;
        private System.Windows.Forms.Button buttonRestoreDeleted;
        private System.Windows.Forms.CheckBox checkBoxProductName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.CheckBox checkBoxDescription;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonResetSearch;
    }
}