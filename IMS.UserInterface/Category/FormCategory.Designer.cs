namespace IMS.UserInterface.Category
{
    partial class FormCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            this.lblFormHeading = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.txtBxCategoryId = new System.Windows.Forms.TextBox();
            this.txtBxCategoryName = new System.Windows.Forms.TextBox();
            this.txtBxCategoryDescription = new System.Windows.Forms.TextBox();
            this.btncategoryCreate = new System.Windows.Forms.Button();
            this.dGVCategory = new System.Windows.Forms.DataGridView();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormHeading
            // 
            this.lblFormHeading.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblFormHeading.AutoSize = true;
            this.lblFormHeading.ForeColor = System.Drawing.Color.Black;
            this.lblFormHeading.Location = new System.Drawing.Point(59, 37);
            this.lblFormHeading.Name = "lblFormHeading";
            this.lblFormHeading.Size = new System.Drawing.Size(49, 13);
            this.lblFormHeading.TabIndex = 0;
            this.lblFormHeading.Text = "Category";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(730, 158);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(61, 13);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Category Id";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(708, 196);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(83, 13);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Catergory Name";
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Location = new System.Drawing.Point(687, 227);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(104, 13);
            this.lblCategoryDescription.TabIndex = 1;
            this.lblCategoryDescription.Text = "category Description";
            // 
            // txtBxCategoryId
            // 
            this.txtBxCategoryId.Location = new System.Drawing.Point(851, 155);
            this.txtBxCategoryId.Name = "txtBxCategoryId";
            this.txtBxCategoryId.Size = new System.Drawing.Size(100, 20);
            this.txtBxCategoryId.TabIndex = 2;
            // 
            // txtBxCategoryName
            // 
            this.txtBxCategoryName.Location = new System.Drawing.Point(851, 196);
            this.txtBxCategoryName.Name = "txtBxCategoryName";
            this.txtBxCategoryName.Size = new System.Drawing.Size(100, 20);
            this.txtBxCategoryName.TabIndex = 2;
            // 
            // txtBxCategoryDescription
            // 
            this.txtBxCategoryDescription.Location = new System.Drawing.Point(851, 224);
            this.txtBxCategoryDescription.Name = "txtBxCategoryDescription";
            this.txtBxCategoryDescription.Size = new System.Drawing.Size(100, 20);
            this.txtBxCategoryDescription.TabIndex = 2;
            // 
            // btncategoryCreate
            // 
            this.btncategoryCreate.Location = new System.Drawing.Point(947, 37);
            this.btncategoryCreate.Name = "btncategoryCreate";
            this.btncategoryCreate.Size = new System.Drawing.Size(75, 23);
            this.btncategoryCreate.TabIndex = 3;
            this.btncategoryCreate.Text = "Create";
            this.btncategoryCreate.UseVisualStyleBackColor = true;
            this.btncategoryCreate.Click += new System.EventHandler(this.btncategoryCreate_Click);
            // 
            // dGVCategory
            // 
            this.dGVCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryName,
            this.CategoryDescription});
            this.dGVCategory.Location = new System.Drawing.Point(62, 147);
            this.dGVCategory.Name = "dGVCategory";
            this.dGVCategory.Size = new System.Drawing.Size(536, 297);
            this.dGVCategory.TabIndex = 4;
            // 
            // CategoryId
            // 
            this.CategoryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CategoryId.DataPropertyName = "Id";
            this.CategoryId.HeaderText = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Width = 83;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CategoryName.DataPropertyName = "Name";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 102;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryDescription.DataPropertyName = "Description";
            this.CategoryDescription.HeaderText = "CategoryDescription";
            this.CategoryDescription.Name = "CategoryDescription";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 484);
            this.Controls.Add(this.dGVCategory);
            this.Controls.Add(this.btncategoryCreate);
            this.Controls.Add(this.txtBxCategoryDescription);
            this.Controls.Add(this.txtBxCategoryName);
            this.Controls.Add(this.txtBxCategoryId);
            this.Controls.Add(this.lblCategoryDescription);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.lblFormHeading);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCategory";
            this.Text = "FormCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dGVCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormHeading;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.TextBox txtBxCategoryId;
        private System.Windows.Forms.TextBox txtBxCategoryName;
        private System.Windows.Forms.TextBox txtBxCategoryDescription;
        private System.Windows.Forms.Button btncategoryCreate;
        private System.Windows.Forms.DataGridView dGVCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDescription;
    }
}