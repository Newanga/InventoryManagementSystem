namespace IMS.UserInterface.Inventory
{
    partial class FormInventory
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
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.dTPDateAdded = new System.Windows.Forms.DateTimePicker();
            this.txtBxOrderId = new System.Windows.Forms.TextBox();
            this.dGVInventory = new System.Windows.Forms.DataGridView();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.btnInventoryAdd = new System.Windows.Forms.Button();
            this.btnInventoryReset = new System.Windows.Forms.Button();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Location = new System.Drawing.Point(528, 34);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(64, 13);
            this.lblDateAdded.TabIndex = 0;
            this.lblDateAdded.Text = "Date Added";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(44, 31);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(45, 13);
            this.lblSupplierName.TabIndex = 1;
            this.lblSupplierName.Text = "Supplier";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(284, 34);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(45, 13);
            this.lblOrderId.TabIndex = 2;
            this.lblOrderId.Text = "Order Id";
            // 
            // dTPDateAdded
            // 
            this.dTPDateAdded.CustomFormat = "MM-dd-yyyy";
            this.dTPDateAdded.Enabled = false;
            this.dTPDateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDateAdded.Location = new System.Drawing.Point(613, 34);
            this.dTPDateAdded.Name = "dTPDateAdded";
            this.dTPDateAdded.Size = new System.Drawing.Size(96, 20);
            this.dTPDateAdded.TabIndex = 4;
            // 
            // txtBxOrderId
            // 
            this.txtBxOrderId.Location = new System.Drawing.Point(363, 31);
            this.txtBxOrderId.Name = "txtBxOrderId";
            this.txtBxOrderId.Size = new System.Drawing.Size(100, 20);
            this.txtBxOrderId.TabIndex = 5;
            // 
            // dGVInventory
            // 
            this.dGVInventory.AllowUserToAddRows = false;
            this.dGVInventory.AllowUserToDeleteRows = false;
            this.dGVInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.SupplierName,
            this.ProductName,
            this.Available,
            this.DateAdded});
            this.dGVInventory.Location = new System.Drawing.Point(47, 178);
            this.dGVInventory.Name = "dGVInventory";
            this.dGVInventory.ReadOnly = true;
            this.dGVInventory.Size = new System.Drawing.Size(908, 185);
            this.dGVInventory.TabIndex = 6;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(95, 26);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSupplier.TabIndex = 3;
            // 
            // btnInventoryAdd
            // 
            this.btnInventoryAdd.Location = new System.Drawing.Point(746, 31);
            this.btnInventoryAdd.Name = "btnInventoryAdd";
            this.btnInventoryAdd.Size = new System.Drawing.Size(75, 23);
            this.btnInventoryAdd.TabIndex = 7;
            this.btnInventoryAdd.Text = "Add";
            this.btnInventoryAdd.UseVisualStyleBackColor = true;
            this.btnInventoryAdd.Click += new System.EventHandler(this.btnInventoryAdd_Click);
            // 
            // btnInventoryReset
            // 
            this.btnInventoryReset.Location = new System.Drawing.Point(846, 32);
            this.btnInventoryReset.Name = "btnInventoryReset";
            this.btnInventoryReset.Size = new System.Drawing.Size(75, 23);
            this.btnInventoryReset.TabIndex = 7;
            this.btnInventoryReset.Text = "Reset";
            this.btnInventoryReset.UseVisualStyleBackColor = true;
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductId.DataPropertyName = "InventoryId";
            this.ProductId.HeaderText = "Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "SupliierName";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Available
            // 
            this.Available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Available.DataPropertyName = "Available";
            this.Available.HeaderText = "Available";
            this.Available.Name = "Available";
            this.Available.ReadOnly = true;
            // 
            // DateAdded
            // 
            this.DateAdded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateAdded.DataPropertyName = "DateAdded";
            this.DateAdded.HeaderText = "DateAdded";
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.ReadOnly = true;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 406);
            this.Controls.Add(this.btnInventoryReset);
            this.Controls.Add(this.btnInventoryAdd);
            this.Controls.Add(this.dGVInventory);
            this.Controls.Add(this.txtBxOrderId);
            this.Controls.Add(this.dTPDateAdded);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblDateAdded);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventory";
            this.Text = "FormInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dGVInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.DateTimePicker dTPDateAdded;
        private System.Windows.Forms.TextBox txtBxOrderId;
        private System.Windows.Forms.DataGridView dGVInventory;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Button btnInventoryAdd;
        private System.Windows.Forms.Button btnInventoryReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdded;
    }
}