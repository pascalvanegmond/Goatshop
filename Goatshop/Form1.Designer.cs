namespace Goatshop
{
    partial class GoatShop
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
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubTitle = new System.Windows.Forms.Label();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.OrderNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalProductsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlacedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelRecentOrders = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCategory
            // 
            this.buttonCategory.Location = new System.Drawing.Point(21, 19);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(75, 33);
            this.buttonCategory.TabIndex = 2;
            this.buttonCategory.Text = "Category";
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Location = new System.Drawing.Point(106, 19);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(75, 33);
            this.buttonSupplier.TabIndex = 2;
            this.buttonSupplier.Text = "Supplier";
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Location = new System.Drawing.Point(190, 19);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(75, 33);
            this.buttonCustomer.TabIndex = 2;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.Location = new System.Drawing.Point(275, 19);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(75, 33);
            this.buttonProduct.TabIndex = 2;
            this.buttonProduct.Text = "Product";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(359, 19);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 33);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOrder);
            this.groupBox1.Controls.Add(this.buttonCategory);
            this.groupBox1.Controls.Add(this.buttonProduct);
            this.groupBox1.Controls.Add(this.buttonSupplier);
            this.groupBox1.Controls.Add(this.buttonCustomer);
            this.groupBox1.Location = new System.Drawing.Point(132, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(126, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(506, 31);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Welcome to the GoatShop administration";
            // 
            // labelSubTitle
            // 
            this.labelSubTitle.AutoSize = true;
            this.labelSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelSubTitle.Location = new System.Drawing.Point(235, 60);
            this.labelSubTitle.Name = "labelSubTitle";
            this.labelSubTitle.Size = new System.Drawing.Size(247, 22);
            this.labelSubTitle.TabIndex = 4;
            this.labelSubTitle.Text = "Click a button for more details";
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
            this.listViewOrder.Location = new System.Drawing.Point(43, 209);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(656, 284);
            this.listViewOrder.TabIndex = 25;
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
            // labelRecentOrders
            // 
            this.labelRecentOrders.AutoSize = true;
            this.labelRecentOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecentOrders.Location = new System.Drawing.Point(38, 181);
            this.labelRecentOrders.Name = "labelRecentOrders";
            this.labelRecentOrders.Size = new System.Drawing.Size(142, 25);
            this.labelRecentOrders.TabIndex = 4;
            this.labelRecentOrders.Text = "Latest Orders";
            // 
            // GoatShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 510);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.labelSubTitle);
            this.Controls.Add(this.labelRecentOrders);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "GoatShop";
            this.Text = "Goat shop";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubTitle;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader OrderNumberHeader;
        private System.Windows.Forms.ColumnHeader CustomerHeader;
        private System.Windows.Forms.ColumnHeader TotalProductsHeader;
        private System.Windows.Forms.ColumnHeader TotalPriceHeader;
        private System.Windows.Forms.ColumnHeader PlacedHeader;
        private System.Windows.Forms.Label labelRecentOrders;
    }
}

