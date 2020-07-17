namespace IMS.UserInterface.Order
{
    partial class FormOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtBxOrderId = new System.Windows.Forms.TextBox();
            this.lblSpecialNote = new System.Windows.Forms.Label();
            this.txtBxSpecialNote = new System.Windows.Forms.TextBox();
            this.lblOrderState = new System.Windows.Forms.Label();
            this.comboBxOrderState = new System.Windows.Forms.ComboBox();
            this.lblPlaceDate = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.dTPPlaceDate = new System.Windows.Forms.DateTimePicker();
            this.dTPDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.txtBxItemId = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.txtBxProductQuantity = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtBxProductPrice = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Supplier,
            this.PlaceDate,
            this.OrderState,
            this.DeliveryDate,
            this.SpecialNotes});
            this.dataGridView1.Location = new System.Drawing.Point(35, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderItemId,
            this.ProductName,
            this.Quantity,
            this.Price});
            this.dataGridView2.Location = new System.Drawing.Point(590, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(408, 192);
            this.dataGridView2.TabIndex = 0;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(76, 53);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(45, 13);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "Order Id";
            // 
            // txtBxOrderId
            // 
            this.txtBxOrderId.Enabled = false;
            this.txtBxOrderId.Location = new System.Drawing.Point(148, 50);
            this.txtBxOrderId.Name = "txtBxOrderId";
            this.txtBxOrderId.Size = new System.Drawing.Size(100, 20);
            this.txtBxOrderId.TabIndex = 2;
            // 
            // lblSpecialNote
            // 
            this.lblSpecialNote.AutoSize = true;
            this.lblSpecialNote.Location = new System.Drawing.Point(53, 79);
            this.lblSpecialNote.Name = "lblSpecialNote";
            this.lblSpecialNote.Size = new System.Drawing.Size(68, 13);
            this.lblSpecialNote.TabIndex = 1;
            this.lblSpecialNote.Text = "Special Note";
            // 
            // txtBxSpecialNote
            // 
            this.txtBxSpecialNote.Enabled = false;
            this.txtBxSpecialNote.Location = new System.Drawing.Point(148, 79);
            this.txtBxSpecialNote.Name = "txtBxSpecialNote";
            this.txtBxSpecialNote.Size = new System.Drawing.Size(100, 20);
            this.txtBxSpecialNote.TabIndex = 2;
            // 
            // lblOrderState
            // 
            this.lblOrderState.AutoSize = true;
            this.lblOrderState.Location = new System.Drawing.Point(323, 111);
            this.lblOrderState.Name = "lblOrderState";
            this.lblOrderState.Size = new System.Drawing.Size(61, 13);
            this.lblOrderState.TabIndex = 1;
            this.lblOrderState.Text = "Order State";
            // 
            // comboBxOrderState
            // 
            this.comboBxOrderState.Enabled = false;
            this.comboBxOrderState.FormattingEnabled = true;
            this.comboBxOrderState.Location = new System.Drawing.Point(408, 111);
            this.comboBxOrderState.Name = "comboBxOrderState";
            this.comboBxOrderState.Size = new System.Drawing.Size(121, 21);
            this.comboBxOrderState.TabIndex = 3;
            // 
            // lblPlaceDate
            // 
            this.lblPlaceDate.AutoSize = true;
            this.lblPlaceDate.Location = new System.Drawing.Point(324, 53);
            this.lblPlaceDate.Name = "lblPlaceDate";
            this.lblPlaceDate.Size = new System.Drawing.Size(60, 13);
            this.lblPlaceDate.TabIndex = 1;
            this.lblPlaceDate.Text = "Place Date";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(313, 78);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(71, 13);
            this.lblDeliveryDate.TabIndex = 1;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // dTPPlaceDate
            // 
            this.dTPPlaceDate.CustomFormat = "\" \"";
            this.dTPPlaceDate.Enabled = false;
            this.dTPPlaceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPPlaceDate.Location = new System.Drawing.Point(408, 53);
            this.dTPPlaceDate.Name = "dTPPlaceDate";
            this.dTPPlaceDate.Size = new System.Drawing.Size(121, 20);
            this.dTPPlaceDate.TabIndex = 4;
            // 
            // dTPDeliveryDate
            // 
            this.dTPDeliveryDate.CustomFormat = "\" \"";
            this.dTPDeliveryDate.Enabled = false;
            this.dTPDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDeliveryDate.Location = new System.Drawing.Point(408, 78);
            this.dTPDeliveryDate.Name = "dTPDeliveryDate";
            this.dTPDeliveryDate.Size = new System.Drawing.Size(121, 20);
            this.dTPDeliveryDate.TabIndex = 4;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(61, 111);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(48, 13);
            this.lblSupplier.TabIndex = 1;
            this.lblSupplier.Text = "Supplier ";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Enabled = false;
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(146, 111);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSupplier.TabIndex = 3;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(737, 56);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(39, 13);
            this.lblItemId.TabIndex = 1;
            this.lblItemId.Text = "Item Id";
            // 
            // txtBxItemId
            // 
            this.txtBxItemId.Enabled = false;
            this.txtBxItemId.Location = new System.Drawing.Point(793, 53);
            this.txtBxItemId.Name = "txtBxItemId";
            this.txtBxItemId.Size = new System.Drawing.Size(100, 20);
            this.txtBxItemId.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(701, 86);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.Enabled = false;
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(793, 86);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProductName.TabIndex = 3;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(690, 121);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(86, 13);
            this.lblProductQuantity.TabIndex = 1;
            this.lblProductQuantity.Text = "Product Quantity";
            // 
            // txtBxProductQuantity
            // 
            this.txtBxProductQuantity.Enabled = false;
            this.txtBxProductQuantity.Location = new System.Drawing.Point(793, 118);
            this.txtBxProductQuantity.Name = "txtBxProductQuantity";
            this.txtBxProductQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBxProductQuantity.TabIndex = 2;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(705, 147);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(71, 13);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "Product Price";
            // 
            // txtBxProductPrice
            // 
            this.txtBxProductPrice.Enabled = false;
            this.txtBxProductPrice.Location = new System.Drawing.Point(793, 144);
            this.txtBxProductPrice.Name = "txtBxProductPrice";
            this.txtBxProductPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBxProductPrice.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // PlaceDate
            // 
            this.PlaceDate.HeaderText = "PlaceDate";
            this.PlaceDate.Name = "PlaceDate";
            this.PlaceDate.ReadOnly = true;
            // 
            // OrderState
            // 
            this.OrderState.HeaderText = "State";
            this.OrderState.Name = "OrderState";
            this.OrderState.ReadOnly = true;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "DeliveryDate";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            // 
            // SpecialNotes
            // 
            this.SpecialNotes.HeaderText = "SpecialNotes";
            this.SpecialNotes.Name = "SpecialNotes";
            this.SpecialNotes.ReadOnly = true;
            // 
            // OrderItemId
            // 
            this.OrderItemId.HeaderText = "Id";
            this.OrderItemId.Name = "OrderItemId";
            this.OrderItemId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 445);
            this.Controls.Add(this.dTPDeliveryDate);
            this.Controls.Add(this.dTPPlaceDate);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.comboBxOrderState);
            this.Controls.Add(this.txtBxSpecialNote);
            this.Controls.Add(this.txtBxProductQuantity);
            this.Controls.Add(this.txtBxProductPrice);
            this.Controls.Add(this.txtBxItemId);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtBxOrderId);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblOrderState);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblPlaceDate);
            this.Controls.Add(this.lblItemId);
            this.Controls.Add(this.lblSpecialNote);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtBxOrderId;
        private System.Windows.Forms.Label lblSpecialNote;
        private System.Windows.Forms.TextBox txtBxSpecialNote;
        private System.Windows.Forms.Label lblOrderState;
        private System.Windows.Forms.ComboBox comboBxOrderState;
        private System.Windows.Forms.Label lblPlaceDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.DateTimePicker dTPPlaceDate;
        private System.Windows.Forms.DateTimePicker dTPDeliveryDate;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.TextBox txtBxItemId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.TextBox txtBxProductQuantity;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtBxProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderState;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}