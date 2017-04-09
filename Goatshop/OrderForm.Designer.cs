namespace Goatshop
{
    partial class OrderForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.checkBoxCustomer = new System.Windows.Forms.CheckBox();
            this.buttonResetSearch = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxOrderNumber = new System.Windows.Forms.CheckBox();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.OrderNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalProductsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlacedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.labelDeleted = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.checkBoxCustomer);
            this.groupBox2.Controls.Add(this.buttonResetSearch);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.checkBoxOrderNumber);
            this.groupBox2.Location = new System.Drawing.Point(731, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 162);
            this.groupBox2.TabIndex = 30;
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
            // checkBoxCustomer
            // 
            this.checkBoxCustomer.AutoSize = true;
            this.checkBoxCustomer.Location = new System.Drawing.Point(17, 70);
            this.checkBoxCustomer.Name = "checkBoxCustomer";
            this.checkBoxCustomer.Size = new System.Drawing.Size(70, 17);
            this.checkBoxCustomer.TabIndex = 22;
            this.checkBoxCustomer.Text = "Customer";
            this.checkBoxCustomer.UseVisualStyleBackColor = true;
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
            // checkBoxOrderNumber
            // 
            this.checkBoxOrderNumber.AutoSize = true;
            this.checkBoxOrderNumber.Checked = true;
            this.checkBoxOrderNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOrderNumber.Location = new System.Drawing.Point(17, 47);
            this.checkBoxOrderNumber.Name = "checkBoxOrderNumber";
            this.checkBoxOrderNumber.Size = new System.Drawing.Size(90, 17);
            this.checkBoxOrderNumber.TabIndex = 22;
            this.checkBoxOrderNumber.Text = "Order number";
            this.checkBoxOrderNumber.UseVisualStyleBackColor = true;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderNumberHeader,
            this.CustomerHeader,
            this.TotalProductsHeader,
            this.TotalPriceHeader,
            this.PlacedHeader});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.Location = new System.Drawing.Point(33, 80);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(666, 357);
            this.listViewOrder.TabIndex = 24;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // OrderNumberHeader
            // 
            this.OrderNumberHeader.Text = "Order number";
            this.OrderNumberHeader.Width = 123;
            // 
            // CustomerHeader
            // 
            this.CustomerHeader.Text = "Customer";
            this.CustomerHeader.Width = 196;
            // 
            // TotalProductsHeader
            // 
            this.TotalProductsHeader.Text = "Total products";
            this.TotalProductsHeader.Width = 91;
            // 
            // TotalPriceHeader
            // 
            this.TotalPriceHeader.Text = "Total price";
            this.TotalPriceHeader.Width = 110;
            // 
            // PlacedHeader
            // 
            this.PlacedHeader.Text = "Placed";
            this.PlacedHeader.Width = 139;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonReturn);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Location = new System.Drawing.Point(731, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 196);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(28, 24);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(28, 154);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 9;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(28, 66);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // labelDeleted
            // 
            this.labelDeleted.AutoSize = true;
            this.labelDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleted.ForeColor = System.Drawing.Color.Red;
            this.labelDeleted.Location = new System.Drawing.Point(456, 44);
            this.labelDeleted.Name = "labelDeleted";
            this.labelDeleted.Size = new System.Drawing.Size(0, 29);
            this.labelDeleted.TabIndex = 25;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(26, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(290, 42);
            this.labelTitle.TabIndex = 26;
            this.labelTitle.Text = "Orders overview";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 656);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDeleted);
            this.Controls.Add(this.labelTitle);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.CheckBox checkBoxCustomer;
        private System.Windows.Forms.Button buttonResetSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBoxOrderNumber;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader OrderNumberHeader;
        private System.Windows.Forms.ColumnHeader CustomerHeader;
        private System.Windows.Forms.ColumnHeader TotalProductsHeader;
        private System.Windows.Forms.ColumnHeader TotalPriceHeader;
        private System.Windows.Forms.ColumnHeader PlacedHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label labelDeleted;
        private System.Windows.Forms.Label labelTitle;
    }
}