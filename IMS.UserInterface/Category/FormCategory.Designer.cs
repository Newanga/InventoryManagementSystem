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
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.txtBxCategoryId = new System.Windows.Forms.TextBox();
            this.txtBxCategoryName = new System.Windows.Forms.TextBox();
            this.txtBxCategoryDescription = new System.Windows.Forms.TextBox();
            this.dGVCategory = new System.Windows.Forms.DataGridView();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.btnCategoryEdit = new System.Windows.Forms.Button();
            this.btnCategoryReset = new System.Windows.Forms.Button();
            this.btnCategoryExistingUpdate = new System.Windows.Forms.Button();
            this.btnCategoryNewUpdate = new System.Windows.Forms.Button();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(69, 58);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(83, 18);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Category Id";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(40, 113);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(112, 18);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Category Name";
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.lblCategoryDescription.Location = new System.Drawing.Point(430, 85);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(157, 20);
            this.lblCategoryDescription.TabIndex = 1;
            this.lblCategoryDescription.Text = "Category Description";
            // 
            // txtBxCategoryId
            // 
            this.txtBxCategoryId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBxCategoryId.BackColor = System.Drawing.Color.White;
            this.txtBxCategoryId.Enabled = false;
            this.txtBxCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCategoryId.Location = new System.Drawing.Point(172, 55);
            this.txtBxCategoryId.Name = "txtBxCategoryId";
            this.txtBxCategoryId.Size = new System.Drawing.Size(231, 22);
            this.txtBxCategoryId.TabIndex = 2;
            // 
            // txtBxCategoryName
            // 
            this.txtBxCategoryName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBxCategoryName.BackColor = System.Drawing.Color.White;
            this.txtBxCategoryName.Enabled = false;
            this.txtBxCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtBxCategoryName.Location = new System.Drawing.Point(172, 110);
            this.txtBxCategoryName.MaxLength = 190;
            this.txtBxCategoryName.Name = "txtBxCategoryName";
            this.txtBxCategoryName.Size = new System.Drawing.Size(230, 23);
            this.txtBxCategoryName.TabIndex = 2;
            // 
            // txtBxCategoryDescription
            // 
            this.txtBxCategoryDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBxCategoryDescription.BackColor = System.Drawing.Color.White;
            this.txtBxCategoryDescription.Enabled = false;
            this.txtBxCategoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtBxCategoryDescription.Location = new System.Drawing.Point(593, 54);
            this.txtBxCategoryDescription.MaxLength = 1990;
            this.txtBxCategoryDescription.Multiline = true;
            this.txtBxCategoryDescription.Name = "txtBxCategoryDescription";
            this.txtBxCategoryDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxCategoryDescription.Size = new System.Drawing.Size(370, 79);
            this.txtBxCategoryDescription.TabIndex = 2;
            // 
            // dGVCategory
            // 
            this.dGVCategory.AllowUserToAddRows = false;
            this.dGVCategory.AllowUserToDeleteRows = false;
            this.dGVCategory.AllowUserToOrderColumns = true;
            this.dGVCategory.AllowUserToResizeRows = false;
            this.dGVCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryName,
            this.CategoryDescription});
            this.dGVCategory.Location = new System.Drawing.Point(43, 231);
            this.dGVCategory.Name = "dGVCategory";
            this.dGVCategory.ReadOnly = true;
            this.dGVCategory.RowHeadersVisible = false;
            this.dGVCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVCategory.Size = new System.Drawing.Size(978, 218);
            this.dGVCategory.TabIndex = 4;
            this.dGVCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCategory_CellDoubleClick);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategoryAdd.Location = new System.Drawing.Point(157, 180);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(130, 23);
            this.btnCategoryAdd.TabIndex = 5;
            this.btnCategoryAdd.Text = "Add";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // btnCategoryEdit
            // 
            this.btnCategoryEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategoryEdit.Enabled = false;
            this.btnCategoryEdit.Location = new System.Drawing.Point(357, 180);
            this.btnCategoryEdit.Name = "btnCategoryEdit";
            this.btnCategoryEdit.Size = new System.Drawing.Size(130, 23);
            this.btnCategoryEdit.TabIndex = 6;
            this.btnCategoryEdit.Text = "Edit";
            this.btnCategoryEdit.UseVisualStyleBackColor = true;
            this.btnCategoryEdit.Click += new System.EventHandler(this.btnCategoryEdit_Click);
            // 
            // btnCategoryReset
            // 
            this.btnCategoryReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategoryReset.Enabled = false;
            this.btnCategoryReset.Location = new System.Drawing.Point(721, 180);
            this.btnCategoryReset.Name = "btnCategoryReset";
            this.btnCategoryReset.Size = new System.Drawing.Size(130, 23);
            this.btnCategoryReset.TabIndex = 8;
            this.btnCategoryReset.Text = "Reset";
            this.btnCategoryReset.UseVisualStyleBackColor = true;
            this.btnCategoryReset.Click += new System.EventHandler(this.btnCategoryReset_Click);
            // 
            // btnCategoryExistingUpdate
            // 
            this.btnCategoryExistingUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategoryExistingUpdate.Enabled = false;
            this.btnCategoryExistingUpdate.Location = new System.Drawing.Point(556, 180);
            this.btnCategoryExistingUpdate.Name = "btnCategoryExistingUpdate";
            this.btnCategoryExistingUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnCategoryExistingUpdate.TabIndex = 9;
            this.btnCategoryExistingUpdate.Text = "Update";
            this.btnCategoryExistingUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryExistingUpdate.Click += new System.EventHandler(this.btnCategoryExistingUpdate_Click);
            // 
            // btnCategoryNewUpdate
            // 
            this.btnCategoryNewUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategoryNewUpdate.Enabled = false;
            this.btnCategoryNewUpdate.Location = new System.Drawing.Point(556, 180);
            this.btnCategoryNewUpdate.Name = "btnCategoryNewUpdate";
            this.btnCategoryNewUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnCategoryNewUpdate.TabIndex = 9;
            this.btnCategoryNewUpdate.Text = "Update";
            this.btnCategoryNewUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryNewUpdate.Click += new System.EventHandler(this.btnCategoryNewUpdate_Click);
            // 
            // CategoryId
            // 
            this.CategoryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CategoryId.DataPropertyName = "Id";
            this.CategoryId.HeaderText = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Width = 83;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CategoryName.DataPropertyName = "Name";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 102;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CategoryDescription.DataPropertyName = "Description";
            this.CategoryDescription.HeaderText = "CategoryDescription";
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.ReadOnly = true;
            this.CategoryDescription.Width = 127;
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 484);
            this.Controls.Add(this.btnCategoryNewUpdate);
            this.Controls.Add(this.btnCategoryExistingUpdate);
            this.Controls.Add(this.btnCategoryReset);
            this.Controls.Add(this.btnCategoryEdit);
            this.Controls.Add(this.btnCategoryAdd);
            this.Controls.Add(this.dGVCategory);
            this.Controls.Add(this.txtBxCategoryDescription);
            this.Controls.Add(this.txtBxCategoryName);
            this.Controls.Add(this.txtBxCategoryId);
            this.Controls.Add(this.lblCategoryDescription);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblCategoryId);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCategory";
            this.Text = "FormCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dGVCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.TextBox txtBxCategoryId;
        private System.Windows.Forms.TextBox txtBxCategoryName;
        private System.Windows.Forms.TextBox txtBxCategoryDescription;
        private System.Windows.Forms.DataGridView dGVCategory;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Button btnCategoryEdit;
        private System.Windows.Forms.Button btnCategoryReset;
        private System.Windows.Forms.Button btnCategoryExistingUpdate;
        private System.Windows.Forms.Button btnCategoryNewUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDescription;
    }
}