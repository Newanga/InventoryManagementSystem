namespace IMS.UserInterface.Supplier

{
    partial class FormSupplier
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
            this.components = new System.ComponentModel.Container();
            this.dGVSupplier = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxSupplierId = new System.Windows.Forms.TextBox();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.txtBxSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierDescription = new System.Windows.Forms.Label();
            this.txtBxSupplierphoneNo = new System.Windows.Forms.TextBox();
            this.lblSupplierPhoneNo = new System.Windows.Forms.Label();
            this.txtBxSupplierAddress = new System.Windows.Forms.TextBox();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblSupplierState = new System.Windows.Forms.Label();
            this.combobxSupplierState = new System.Windows.Forms.ComboBox();
            this.btnSupplierAdd = new System.Windows.Forms.Button();
            this.btnSupplierEdit = new System.Windows.Forms.Button();
            this.btnSupplierExistingUpdate = new System.Windows.Forms.Button();
            this.btnSupplierNewUpdate = new System.Windows.Forms.Button();
            this.btnSupplierReset = new System.Windows.Forms.Button();
            this.txtBxSupplierDescription = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVSupplier
            // 
            this.dGVSupplier.AllowUserToAddRows = false;
            this.dGVSupplier.AllowUserToDeleteRows = false;
            this.dGVSupplier.AllowUserToResizeColumns = false;
            this.dGVSupplier.AllowUserToResizeRows = false;
            this.dGVSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.SupplierName,
            this.SupplierDescription,
            this.SupplierPhoneNo,
            this.SupplierAddress,
            this.SupplierState});
            this.dGVSupplier.Location = new System.Drawing.Point(31, 217);
            this.dGVSupplier.Name = "dGVSupplier";
            this.dGVSupplier.ReadOnly = true;
            this.dGVSupplier.RowHeadersVisible = false;
            this.dGVSupplier.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dGVSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVSupplier.Size = new System.Drawing.Size(978, 218);
            this.dGVSupplier.TabIndex = 17;
            this.dGVSupplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSupplier_CellDoubleClick);
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "Id";
            this.SupplierId.HeaderText = "Id";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "Name";
            this.SupplierName.HeaderText = "Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // SupplierDescription
            // 
            this.SupplierDescription.DataPropertyName = "Description";
            this.SupplierDescription.HeaderText = "Description";
            this.SupplierDescription.Name = "SupplierDescription";
            this.SupplierDescription.ReadOnly = true;
            // 
            // SupplierPhoneNo
            // 
            this.SupplierPhoneNo.DataPropertyName = "PhoneNumber";
            this.SupplierPhoneNo.HeaderText = "PhoneNo";
            this.SupplierPhoneNo.Name = "SupplierPhoneNo";
            this.SupplierPhoneNo.ReadOnly = true;
            // 
            // SupplierAddress
            // 
            this.SupplierAddress.DataPropertyName = "Address";
            this.SupplierAddress.HeaderText = "Address";
            this.SupplierAddress.Name = "SupplierAddress";
            this.SupplierAddress.ReadOnly = true;
            // 
            // SupplierState
            // 
            this.SupplierState.DataPropertyName = "State";
            this.SupplierState.HeaderText = "State";
            this.SupplierState.Name = "SupplierState";
            this.SupplierState.ReadOnly = true;
            // 
            // txtBxSupplierId
            // 
            this.txtBxSupplierId.Enabled = false;
            this.txtBxSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBxSupplierId.Location = new System.Drawing.Point(227, 31);
            this.txtBxSupplierId.Name = "txtBxSupplierId";
            this.txtBxSupplierId.ShortcutsEnabled = false;
            this.txtBxSupplierId.Size = new System.Drawing.Size(256, 22);
            this.txtBxSupplierId.TabIndex = 18;
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSupplierId.Location = new System.Drawing.Point(96, 31);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(76, 18);
            this.lblSupplierId.TabIndex = 19;
            this.lblSupplierId.Text = "Supplier Id";
            // 
            // txtBxSupplierName
            // 
            this.txtBxSupplierName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBxSupplierName.Enabled = false;
            this.txtBxSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBxSupplierName.Location = new System.Drawing.Point(227, 71);
            this.txtBxSupplierName.MaxLength = 490;
            this.txtBxSupplierName.Name = "txtBxSupplierName";
            this.txtBxSupplierName.Size = new System.Drawing.Size(256, 22);
            this.txtBxSupplierName.TabIndex = 25;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSupplierName.Location = new System.Drawing.Point(67, 71);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(105, 18);
            this.lblSupplierName.TabIndex = 19;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblSupplierDescription
            // 
            this.lblSupplierDescription.AutoSize = true;
            this.lblSupplierDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSupplierDescription.Location = new System.Drawing.Point(32, 122);
            this.lblSupplierDescription.Name = "lblSupplierDescription";
            this.lblSupplierDescription.Size = new System.Drawing.Size(140, 18);
            this.lblSupplierDescription.TabIndex = 19;
            this.lblSupplierDescription.Text = "Supplier Description";
            // 
            // txtBxSupplierphoneNo
            // 
            this.txtBxSupplierphoneNo.Enabled = false;
            this.txtBxSupplierphoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBxSupplierphoneNo.Location = new System.Drawing.Point(728, 32);
            this.txtBxSupplierphoneNo.MaxLength = 11;
            this.txtBxSupplierphoneNo.Name = "txtBxSupplierphoneNo";
            this.txtBxSupplierphoneNo.ShortcutsEnabled = false;
            this.txtBxSupplierphoneNo.Size = new System.Drawing.Size(215, 22);
            this.txtBxSupplierphoneNo.TabIndex = 18;
            this.txtBxSupplierphoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxSupplierphoneNo_KeyPress);
            // 
            // lblSupplierPhoneNo
            // 
            this.lblSupplierPhoneNo.AutoSize = true;
            this.lblSupplierPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSupplierPhoneNo.Location = new System.Drawing.Point(579, 32);
            this.lblSupplierPhoneNo.Name = "lblSupplierPhoneNo";
            this.lblSupplierPhoneNo.Size = new System.Drawing.Size(128, 18);
            this.lblSupplierPhoneNo.TabIndex = 19;
            this.lblSupplierPhoneNo.Text = "Supplier PhoneNo";
            // 
            // txtBxSupplierAddress
            // 
            this.txtBxSupplierAddress.Enabled = false;
            this.txtBxSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBxSupplierAddress.Location = new System.Drawing.Point(728, 106);
            this.txtBxSupplierAddress.MaxLength = 240;
            this.txtBxSupplierAddress.Multiline = true;
            this.txtBxSupplierAddress.Name = "txtBxSupplierAddress";
            this.txtBxSupplierAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxSupplierAddress.Size = new System.Drawing.Size(215, 51);
            this.txtBxSupplierAddress.TabIndex = 18;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSupplierAddress.Location = new System.Drawing.Point(588, 122);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(119, 18);
            this.lblSupplierAddress.TabIndex = 19;
            this.lblSupplierAddress.Text = "Supplier Address";
            // 
            // lblSupplierState
            // 
            this.lblSupplierState.AutoSize = true;
            this.lblSupplierState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSupplierState.Location = new System.Drawing.Point(608, 71);
            this.lblSupplierState.Name = "lblSupplierState";
            this.lblSupplierState.Size = new System.Drawing.Size(99, 18);
            this.lblSupplierState.TabIndex = 19;
            this.lblSupplierState.Text = "Supplier State";
            // 
            // combobxSupplierState
            // 
            this.combobxSupplierState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxSupplierState.Enabled = false;
            this.combobxSupplierState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.combobxSupplierState.FormattingEnabled = true;
            this.combobxSupplierState.Location = new System.Drawing.Point(728, 71);
            this.combobxSupplierState.Name = "combobxSupplierState";
            this.combobxSupplierState.Size = new System.Drawing.Size(215, 24);
            this.combobxSupplierState.TabIndex = 20;
            // 
            // btnSupplierAdd
            // 
            this.btnSupplierAdd.Location = new System.Drawing.Point(280, 176);
            this.btnSupplierAdd.Name = "btnSupplierAdd";
            this.btnSupplierAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSupplierAdd.TabIndex = 21;
            this.btnSupplierAdd.Text = "Add";
            this.btnSupplierAdd.UseVisualStyleBackColor = true;
            this.btnSupplierAdd.Click += new System.EventHandler(this.btnSupplierAdd_Click);
            // 
            // btnSupplierEdit
            // 
            this.btnSupplierEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btnSupplierEdit.Enabled = false;
            this.btnSupplierEdit.Location = new System.Drawing.Point(398, 176);
            this.btnSupplierEdit.Name = "btnSupplierEdit";
            this.btnSupplierEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSupplierEdit.TabIndex = 21;
            this.btnSupplierEdit.Text = "Edit";
            this.btnSupplierEdit.UseVisualStyleBackColor = true;
            this.btnSupplierEdit.Click += new System.EventHandler(this.btnSupplierEdit_Click);
            // 
            // btnSupplierExistingUpdate
            // 
            this.btnSupplierExistingUpdate.Enabled = false;
            this.btnSupplierExistingUpdate.Location = new System.Drawing.Point(515, 176);
            this.btnSupplierExistingUpdate.Name = "btnSupplierExistingUpdate";
            this.btnSupplierExistingUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSupplierExistingUpdate.TabIndex = 21;
            this.btnSupplierExistingUpdate.Text = "Update";
            this.btnSupplierExistingUpdate.UseVisualStyleBackColor = true;
            this.btnSupplierExistingUpdate.Click += new System.EventHandler(this.btnSupplierExistingUpdate_Click);
            // 
            // btnSupplierNewUpdate
            // 
            this.btnSupplierNewUpdate.Enabled = false;
            this.btnSupplierNewUpdate.Location = new System.Drawing.Point(515, 176);
            this.btnSupplierNewUpdate.Name = "btnSupplierNewUpdate";
            this.btnSupplierNewUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSupplierNewUpdate.TabIndex = 21;
            this.btnSupplierNewUpdate.Text = "Update";
            this.btnSupplierNewUpdate.UseVisualStyleBackColor = true;
            this.btnSupplierNewUpdate.Click += new System.EventHandler(this.btnSupplierNewUpdate_Click);
            // 
            // btnSupplierReset
            // 
            this.btnSupplierReset.Enabled = false;
            this.btnSupplierReset.Location = new System.Drawing.Point(632, 176);
            this.btnSupplierReset.Name = "btnSupplierReset";
            this.btnSupplierReset.Size = new System.Drawing.Size(75, 23);
            this.btnSupplierReset.TabIndex = 21;
            this.btnSupplierReset.Text = "Reset";
            this.btnSupplierReset.UseVisualStyleBackColor = true;
            this.btnSupplierReset.Click += new System.EventHandler(this.btnSupplierReset_Click);
            // 
            // txtBxSupplierDescription
            // 
            this.txtBxSupplierDescription.Enabled = false;
            this.txtBxSupplierDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBxSupplierDescription.Location = new System.Drawing.Point(227, 106);
            this.txtBxSupplierDescription.MaxLength = 1990;
            this.txtBxSupplierDescription.Multiline = true;
            this.txtBxSupplierDescription.Name = "txtBxSupplierDescription";
            this.txtBxSupplierDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxSupplierDescription.Size = new System.Drawing.Size(256, 51);
            this.txtBxSupplierDescription.TabIndex = 22;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 484);
            this.Controls.Add(this.btnSupplierNewUpdate);
            this.Controls.Add(this.txtBxSupplierDescription);
            this.Controls.Add(this.btnSupplierReset);
            this.Controls.Add(this.btnSupplierEdit);
            this.Controls.Add(this.btnSupplierAdd);
            this.Controls.Add(this.combobxSupplierState);
            this.Controls.Add(this.lblSupplierState);
            this.Controls.Add(this.lblSupplierDescription);
            this.Controls.Add(this.lblSupplierAddress);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.txtBxSupplierAddress);
            this.Controls.Add(this.txtBxSupplierName);
            this.Controls.Add(this.lblSupplierPhoneNo);
            this.Controls.Add(this.lblSupplierId);
            this.Controls.Add(this.txtBxSupplierphoneNo);
            this.Controls.Add(this.txtBxSupplierId);
            this.Controls.Add(this.dGVSupplier);
            this.Controls.Add(this.btnSupplierExistingUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSupplier";
            this.Text = "FormSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.dGVSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVSupplier;
        private System.Windows.Forms.TextBox txtBxSupplierId;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.TextBox txtBxSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierDescription;
        private System.Windows.Forms.TextBox txtBxSupplierphoneNo;
        private System.Windows.Forms.Label lblSupplierPhoneNo;
        private System.Windows.Forms.TextBox txtBxSupplierAddress;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblSupplierState;
        private System.Windows.Forms.ComboBox combobxSupplierState;
        private System.Windows.Forms.Button btnSupplierAdd;
        private System.Windows.Forms.Button btnSupplierEdit;
        private System.Windows.Forms.Button btnSupplierExistingUpdate;
        private System.Windows.Forms.Button btnSupplierNewUpdate;
        private System.Windows.Forms.Button btnSupplierReset;
        private System.Windows.Forms.TextBox txtBxSupplierDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierState;
    }
}