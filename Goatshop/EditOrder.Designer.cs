namespace Goatshop
{
    partial class EditOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCreated = new System.Windows.Forms.TextBox();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.labelCreated = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.listViewCustomer = new System.Windows.Forms.ListView();
            this.FirstnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.checkBoxLastname = new System.Windows.Forms.CheckBox();
            this.buttonResetSearchCustomer = new System.Windows.Forms.Button();
            this.checkBoxFirstname = new System.Windows.Forms.CheckBox();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTitleCustomer = new System.Windows.Forms.Label();
            this.labelTitleProduct = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.checkBoxProductDescription = new System.Windows.Forms.CheckBox();
            this.buttonResetSearchProduct = new System.Windows.Forms.Button();
            this.checkBoxProductName = new System.Windows.Forms.CheckBox();
            this.checkBoxCategory = new System.Windows.Forms.CheckBox();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.ProductNameHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductDescriptionHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.labelTitleAdd = new System.Windows.Forms.Label();
            this.labelTitleOrder = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDeleteOrderRow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCreated);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelTitleCustomer);
            this.groupBox1.Controls.Add(this.textBoxOrderNumber);
            this.groupBox1.Controls.Add(this.labelCreated);
            this.groupBox1.Controls.Add(this.listViewCustomer);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.labelOrderNumber);
            this.groupBox1.Controls.Add(this.buttonReturn);
            this.groupBox1.Location = new System.Drawing.Point(32, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 609);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBoxCreated
            // 
            this.textBoxCreated.Enabled = false;
            this.textBoxCreated.Location = new System.Drawing.Point(42, 96);
            this.textBoxCreated.Name = "textBoxCreated";
            this.textBoxCreated.Size = new System.Drawing.Size(203, 20);
            this.textBoxCreated.TabIndex = 1;
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(42, 48);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(203, 20);
            this.textBoxOrderNumber.TabIndex = 0;
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.Location = new System.Drawing.Point(39, 80);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(56, 13);
            this.labelCreated.TabIndex = 2;
            this.labelCreated.Text = "Created at";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(132, 549);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 36);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Location = new System.Drawing.Point(39, 32);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(71, 13);
            this.labelOrderNumber.TabIndex = 2;
            this.labelOrderNumber.Text = "Order number";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(29, 549);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(100, 36);
            this.buttonReturn.TabIndex = 7;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(27, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(125, 29);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Edit order:";
            // 
            // listViewCustomer
            // 
            this.listViewCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstnameHeader,
            this.LastnameHeader});
            this.listViewCustomer.FullRowSelect = true;
            this.listViewCustomer.GridLines = true;
            this.listViewCustomer.Location = new System.Drawing.Point(22, 161);
            this.listViewCustomer.Name = "listViewCustomer";
            this.listViewCustomer.Size = new System.Drawing.Size(253, 166);
            this.listViewCustomer.TabIndex = 11;
            this.listViewCustomer.UseCompatibleStateImageBehavior = false;
            this.listViewCustomer.View = System.Windows.Forms.View.Details;
            // 
            // FirstnameHeader
            // 
            this.FirstnameHeader.Text = "Firstname";
            this.FirstnameHeader.Width = 112;
            // 
            // LastnameHeader
            // 
            this.LastnameHeader.Text = "Lastname";
            this.LastnameHeader.Width = 134;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearchCustomer);
            this.groupBox2.Controls.Add(this.checkBoxLastname);
            this.groupBox2.Controls.Add(this.buttonResetSearchCustomer);
            this.groupBox2.Controls.Add(this.checkBoxFirstname);
            this.groupBox2.Location = new System.Drawing.Point(23, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 136);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search customer";
            // 
            // textBoxSearchCustomer
            // 
            this.textBoxSearchCustomer.Location = new System.Drawing.Point(17, 19);
            this.textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            this.textBoxSearchCustomer.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchCustomer.TabIndex = 23;
            this.textBoxSearchCustomer.TextChanged += new System.EventHandler(this.textBoxSearchCustomer_TextChanged);
            // 
            // checkBoxLastname
            // 
            this.checkBoxLastname.AutoSize = true;
            this.checkBoxLastname.Location = new System.Drawing.Point(17, 70);
            this.checkBoxLastname.Name = "checkBoxLastname";
            this.checkBoxLastname.Size = new System.Drawing.Size(72, 17);
            this.checkBoxLastname.TabIndex = 22;
            this.checkBoxLastname.Text = "Lastname";
            this.checkBoxLastname.UseVisualStyleBackColor = true;
            // 
            // buttonResetSearchCustomer
            // 
            this.buttonResetSearchCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonResetSearchCustomer.Location = new System.Drawing.Point(17, 98);
            this.buttonResetSearchCustomer.Name = "buttonResetSearchCustomer";
            this.buttonResetSearchCustomer.Size = new System.Drawing.Size(100, 23);
            this.buttonResetSearchCustomer.TabIndex = 6;
            this.buttonResetSearchCustomer.Text = "Reset";
            this.buttonResetSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonResetSearchCustomer.Click += new System.EventHandler(this.buttonResetSearchCustomer_Click);
            // 
            // checkBoxFirstname
            // 
            this.checkBoxFirstname.AutoSize = true;
            this.checkBoxFirstname.Checked = true;
            this.checkBoxFirstname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFirstname.Location = new System.Drawing.Point(17, 47);
            this.checkBoxFirstname.Name = "checkBoxFirstname";
            this.checkBoxFirstname.Size = new System.Drawing.Size(71, 17);
            this.checkBoxFirstname.TabIndex = 22;
            this.checkBoxFirstname.Text = "Firstname";
            this.checkBoxFirstname.UseVisualStyleBackColor = true;
            // 
            // listViewProduct
            // 
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.DescriptionHeader,
            this.PriceHeader,
            this.StockHeader,
            this.CategoryHeader});
            this.listViewProduct.FullRowSelect = true;
            this.listViewProduct.GridLines = true;
            this.listViewProduct.Location = new System.Drawing.Point(369, 50);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(595, 151);
            this.listViewProduct.TabIndex = 32;
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
            // labelTitleCustomer
            // 
            this.labelTitleCustomer.AutoSize = true;
            this.labelTitleCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCustomer.Location = new System.Drawing.Point(19, 136);
            this.labelTitleCustomer.Name = "labelTitleCustomer";
            this.labelTitleCustomer.Size = new System.Drawing.Size(91, 24);
            this.labelTitleCustomer.TabIndex = 2;
            this.labelTitleCustomer.Text = "Customer";
            // 
            // labelTitleProduct
            // 
            this.labelTitleProduct.AutoSize = true;
            this.labelTitleProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleProduct.Location = new System.Drawing.Point(365, 23);
            this.labelTitleProduct.Name = "labelTitleProduct";
            this.labelTitleProduct.Size = new System.Drawing.Size(84, 24);
            this.labelTitleProduct.TabIndex = 2;
            this.labelTitleProduct.Text = "Products";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSearchProduct);
            this.groupBox3.Controls.Add(this.checkBoxCategory);
            this.groupBox3.Controls.Add(this.checkBoxProductDescription);
            this.groupBox3.Controls.Add(this.buttonResetSearchProduct);
            this.groupBox3.Controls.Add(this.checkBoxProductName);
            this.groupBox3.Location = new System.Drawing.Point(981, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 158);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search product";
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Location = new System.Drawing.Point(17, 19);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchProduct.TabIndex = 23;
            this.textBoxSearchProduct.TextChanged += new System.EventHandler(this.textBoxSearchProduct_TextChanged);
            // 
            // checkBoxProductDescription
            // 
            this.checkBoxProductDescription.AutoSize = true;
            this.checkBoxProductDescription.Location = new System.Drawing.Point(17, 70);
            this.checkBoxProductDescription.Name = "checkBoxProductDescription";
            this.checkBoxProductDescription.Size = new System.Drawing.Size(79, 17);
            this.checkBoxProductDescription.TabIndex = 22;
            this.checkBoxProductDescription.Text = "Description";
            this.checkBoxProductDescription.UseVisualStyleBackColor = true;
            // 
            // buttonResetSearchProduct
            // 
            this.buttonResetSearchProduct.Location = new System.Drawing.Point(17, 119);
            this.buttonResetSearchProduct.Name = "buttonResetSearchProduct";
            this.buttonResetSearchProduct.Size = new System.Drawing.Size(100, 23);
            this.buttonResetSearchProduct.TabIndex = 6;
            this.buttonResetSearchProduct.Text = "Reset";
            this.buttonResetSearchProduct.UseVisualStyleBackColor = true;
            this.buttonResetSearchProduct.Click += new System.EventHandler(this.buttonResetSearchProduct_Click);
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
            // checkBoxCategory
            // 
            this.checkBoxCategory.AutoSize = true;
            this.checkBoxCategory.Location = new System.Drawing.Point(17, 93);
            this.checkBoxCategory.Name = "checkBoxCategory";
            this.checkBoxCategory.Size = new System.Drawing.Size(68, 17);
            this.checkBoxCategory.TabIndex = 22;
            this.checkBoxCategory.Text = "Category";
            this.checkBoxCategory.UseVisualStyleBackColor = true;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductNameHeader1,
            this.ProductDescriptionHeader2,
            this.QuantityHeader5,
            this.PriceHeader4,
            this.TotalPriceHeader3});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.Location = new System.Drawing.Point(369, 313);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(595, 230);
            this.listViewOrder.TabIndex = 34;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // ProductNameHeader1
            // 
            this.ProductNameHeader1.Text = "Product name";
            this.ProductNameHeader1.Width = 144;
            // 
            // ProductDescriptionHeader2
            // 
            this.ProductDescriptionHeader2.Text = "Description";
            this.ProductDescriptionHeader2.Width = 233;
            // 
            // TotalPriceHeader3
            // 
            this.TotalPriceHeader3.Text = "Total price";
            this.TotalPriceHeader3.Width = 70;
            // 
            // PriceHeader4
            // 
            this.PriceHeader4.Text = "Price";
            this.PriceHeader4.Width = 64;
            // 
            // QuantityHeader5
            // 
            this.QuantityHeader5.Text = "Quantity";
            this.QuantityHeader5.Width = 79;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(419, 243);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(82, 20);
            this.numericQuantity.TabIndex = 35;
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Location = new System.Drawing.Point(537, 243);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(100, 23);
            this.buttonAddToOrder.TabIndex = 24;
            this.buttonAddToOrder.Text = "Add to order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // labelTitleAdd
            // 
            this.labelTitleAdd.AutoSize = true;
            this.labelTitleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleAdd.Location = new System.Drawing.Point(366, 216);
            this.labelTitleAdd.Name = "labelTitleAdd";
            this.labelTitleAdd.Size = new System.Drawing.Size(325, 18);
            this.labelTitleAdd.TabIndex = 2;
            this.labelTitleAdd.Text = "Select a product and add it X times to your order";
            // 
            // labelTitleOrder
            // 
            this.labelTitleOrder.AutoSize = true;
            this.labelTitleOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleOrder.Location = new System.Drawing.Point(365, 286);
            this.labelTitleOrder.Name = "labelTitleOrder";
            this.labelTitleOrder.Size = new System.Drawing.Size(59, 24);
            this.labelTitleOrder.TabIndex = 2;
            this.labelTitleOrder.Text = "Order";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.buttonDeleteOrderRow);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(981, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 158);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search product";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBoxSearchProduct_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrderRow
            // 
            this.buttonDeleteOrderRow.Location = new System.Drawing.Point(17, 90);
            this.buttonDeleteOrderRow.Name = "buttonDeleteOrderRow";
            this.buttonDeleteOrderRow.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteOrderRow.TabIndex = 6;
            this.buttonDeleteOrderRow.Text = "Delete selected";
            this.buttonDeleteOrderRow.UseVisualStyleBackColor = true;
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 744);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.labelTitleOrder);
            this.Controls.Add(this.labelTitleAdd);
            this.Controls.Add(this.labelTitleProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCreated;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView listViewCustomer;
        private System.Windows.Forms.ColumnHeader FirstnameHeader;
        private System.Windows.Forms.ColumnHeader LastnameHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearchCustomer;
        private System.Windows.Forms.CheckBox checkBoxLastname;
        private System.Windows.Forms.Button buttonResetSearchCustomer;
        private System.Windows.Forms.CheckBox checkBoxFirstname;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader DescriptionHeader;
        private System.Windows.Forms.ColumnHeader PriceHeader;
        private System.Windows.Forms.ColumnHeader StockHeader;
        private System.Windows.Forms.ColumnHeader CategoryHeader;
        private System.Windows.Forms.Label labelTitleCustomer;
        private System.Windows.Forms.Label labelTitleProduct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.CheckBox checkBoxProductDescription;
        private System.Windows.Forms.Button buttonResetSearchProduct;
        private System.Windows.Forms.CheckBox checkBoxProductName;
        private System.Windows.Forms.CheckBox checkBoxCategory;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader ProductNameHeader1;
        private System.Windows.Forms.ColumnHeader ProductDescriptionHeader2;
        private System.Windows.Forms.ColumnHeader QuantityHeader5;
        private System.Windows.Forms.ColumnHeader PriceHeader4;
        private System.Windows.Forms.ColumnHeader TotalPriceHeader3;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Label labelTitleAdd;
        private System.Windows.Forms.Label labelTitleOrder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonDeleteOrderRow;
        private System.Windows.Forms.Button button1;
    }
}