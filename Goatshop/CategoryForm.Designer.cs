namespace Goatshop
{
    partial class CategoryForm
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
            this.listViewCategory = new System.Windows.Forms.ListView();
            this.CategoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCategory
            // 
            this.listViewCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CategoryHeader,
            this.DescriptionHeader});
            this.listViewCategory.FullRowSelect = true;
            this.listViewCategory.GridLines = true;
            this.listViewCategory.Location = new System.Drawing.Point(56, 39);
            this.listViewCategory.Name = "listViewCategory";
            this.listViewCategory.Size = new System.Drawing.Size(297, 357);
            this.listViewCategory.TabIndex = 0;
            this.listViewCategory.UseCompatibleStateImageBehavior = false;
            this.listViewCategory.View = System.Windows.Forms.View.Details;
            // 
            // CategoryHeader
            // 
            this.CategoryHeader.Text = "Category";
            this.CategoryHeader.Width = 94;
            // 
            // DescriptionHeader
            // 
            this.DescriptionHeader.Text = "Description";
            this.DescriptionHeader.Width = 197;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(398, 136);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(398, 184);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(398, 253);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 433);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listViewCategory);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCategory;
        private System.Windows.Forms.ColumnHeader CategoryHeader;
        private System.Windows.Forms.ColumnHeader DescriptionHeader;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonReturn;
    }
}