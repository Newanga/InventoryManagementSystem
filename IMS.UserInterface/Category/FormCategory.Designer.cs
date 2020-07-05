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
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.dGVCategory = new System.Windows.Forms.DataGridView();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCategoryNewUpdate = new System.Windows.Forms.Button();
            this.btnCategoryReset = new System.Windows.Forms.Button();
            this.btnCategoryEdit = new System.Windows.Forms.Button();
            this.btnCategoryExistingUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormHeading
            // 
            this.lblFormHeading.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblFormHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFormHeading.AutoSize = true;
            this.lblFormHeading.ForeColor = System.Drawing.Color.Black;
            this.lblFormHeading.Location = new System.Drawing.Point(435, 25);
            this.lblFormHeading.Name = "lblFormHeading";
            this.lblFormHeading.Size = new System.Drawing.Size(49, 13);
            this.lblFormHeading.TabIndex = 0;
            this.lblFormHeading.Text = "Category";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(40, 118);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(83, 18);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Category Id";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(40, 169);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(112, 18);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Category Name";
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryDescription.Location = new System.Drawing.Point(412, 115);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(134, 16);
            this.lblCategoryDescription.TabIndex = 1;
            this.lblCategoryDescription.Text = "Category Description";
            // 
            // txtBxCategoryId
            // 
            this.txtBxCategoryId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBxCategoryId.Enabled = false;
            this.txtBxCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCategoryId.Location = new System.Drawing.Point(172, 115);
            this.txtBxCategoryId.Name = "txtBxCategoryId";
            this.txtBxCategoryId.Size = new System.Drawing.Size(231, 24);
            this.txtBxCategoryId.TabIndex = 2;
            // 
            // txtBxCategoryName
            // 
            this.txtBxCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBxCategoryName.Enabled = false;
            this.txtBxCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCategoryName.Location = new System.Drawing.Point(172, 169);
            this.txtBxCategoryName.Name = "txtBxCategoryName";
            this.txtBxCategoryName.Size = new System.Drawing.Size(230, 24);
            this.txtBxCategoryName.TabIndex = 2;
            // 
            // txtBxCategoryDescription
            // 
            this.txtBxCategoryDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBxCategoryDescription.Enabled = false;
            this.txtBxCategoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCategoryDescription.Location = new System.Drawing.Point(552, 118);
            this.txtBxCategoryDescription.Multiline = true;
            this.txtBxCategoryDescription.Name = "txtBxCategoryDescription";
            this.txtBxCategoryDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxCategoryDescription.Size = new System.Drawing.Size(319, 75);
            this.txtBxCategoryDescription.TabIndex = 2;
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryAdd.Location = new System.Drawing.Point(891, 25);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(131, 23);
            this.btnCategoryAdd.TabIndex = 3;
            this.btnCategoryAdd.Text = "Add";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // dGVCategory
            // 
            this.dGVCategory.AllowUserToDeleteRows = false;
            this.dGVCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryName,
            this.CategoryDescription});
            this.dGVCategory.Location = new System.Drawing.Point(43, 231);
            this.dGVCategory.Name = "dGVCategory";
            this.dGVCategory.ReadOnly = true;
            this.dGVCategory.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dGVCategory.Size = new System.Drawing.Size(978, 218);
            this.dGVCategory.TabIndex = 4;
            this.dGVCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCategory_CellDoubleClick);
            // 
            // CategoryId
            // 
            this.CategoryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CategoryId.DataPropertyName = "Id";
            this.CategoryId.HeaderText = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Width = 83;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CategoryName.DataPropertyName = "Name";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 102;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryDescription.DataPropertyName = "Description";
            this.CategoryDescription.HeaderText = "CategoryDescription";
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.ReadOnly = true;
            // 
            // btnCategoryNewUpdate
            // 
            this.btnCategoryNewUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryNewUpdate.Enabled = false;
            this.btnCategoryNewUpdate.Location = new System.Drawing.Point(893, 154);
            this.btnCategoryNewUpdate.Name = "btnCategoryNewUpdate";
            this.btnCategoryNewUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnCategoryNewUpdate.TabIndex = 3;
            this.btnCategoryNewUpdate.Text = "Update";
            this.btnCategoryNewUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryNewUpdate.Click += new System.EventHandler(this.btnCategoryNewUpdate_Click);
            // 
            // btnCategoryReset
            // 
            this.btnCategoryReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryReset.Enabled = false;
            this.btnCategoryReset.Location = new System.Drawing.Point(891, 183);
            this.btnCategoryReset.Name = "btnCategoryReset";
            this.btnCategoryReset.Size = new System.Drawing.Size(130, 23);
            this.btnCategoryReset.TabIndex = 3;
            this.btnCategoryReset.Text = "Reset";
            this.btnCategoryReset.UseVisualStyleBackColor = true;
            this.btnCategoryReset.Enter += new System.EventHandler(this.btnCategoryReset_Click);
            // 
            // btnCategoryEdit
            // 
            this.btnCategoryEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryEdit.Enabled = false;
            this.btnCategoryEdit.Location = new System.Drawing.Point(893, 91);
            this.btnCategoryEdit.Name = "btnCategoryEdit";
            this.btnCategoryEdit.Size = new System.Drawing.Size(130, 23);
            this.btnCategoryEdit.TabIndex = 3;
            this.btnCategoryEdit.Text = "Edit";
            this.btnCategoryEdit.UseVisualStyleBackColor = true;
            this.btnCategoryEdit.Click += new System.EventHandler(this.btnCategoryEdit_Click);
            // 
            // btnCategoryExistingUpdate
            // 
            this.btnCategoryExistingUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryExistingUpdate.Enabled = false;
            this.btnCategoryExistingUpdate.Location = new System.Drawing.Point(893, 133);
            this.btnCategoryExistingUpdate.Name = "btnCategoryExistingUpdate";
            this.btnCategoryExistingUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnCategoryExistingUpdate.TabIndex = 3;
            this.btnCategoryExistingUpdate.Text = "Update";
            this.btnCategoryExistingUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryExistingUpdate.Click += new System.EventHandler(this.btnCategoryExistingUpdate_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 484);
            this.Controls.Add(this.btnCategoryNewUpdate);
            this.Controls.Add(this.dGVCategory);
            this.Controls.Add(this.btnCategoryEdit);
            this.Controls.Add(this.btnCategoryReset);
            this.Controls.Add(this.btnCategoryExistingUpdate);
            this.Controls.Add(this.btnCategoryAdd);
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
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.DataGridView dGVCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDescription;
        private System.Windows.Forms.Button btnCategoryNewUpdate;
        private System.Windows.Forms.Button btnCategoryReset;
        private System.Windows.Forms.Button btnCategoryEdit;
        private System.Windows.Forms.Button btnCategoryExistingUpdate;
    }
}