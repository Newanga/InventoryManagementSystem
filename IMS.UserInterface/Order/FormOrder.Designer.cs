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
            this.dGVOrders = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVOrderItems = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.comboBxSupplier = new System.Windows.Forms.ComboBox();
            this.lblOrderItemName = new System.Windows.Forms.Label();
            this.comboBxOrderItemName = new System.Windows.Forms.ComboBox();
            this.lblOrderItemQuantity = new System.Windows.Forms.Label();
            this.txtBxOrderItemQuantity = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtBxOrderItemPrice = new System.Windows.Forms.TextBox();
            this.btnNewOrderCreate = new System.Windows.Forms.Button();
            this.btnOrderItemAdd = new System.Windows.Forms.Button();
            this.btnOrderItemEdit = new System.Windows.Forms.Button();
            this.btnOrderItemRemove = new System.Windows.Forms.Button();
            this.btnOrderItemUpdate = new System.Windows.Forms.Button();
            this.btnOrderItemCancel = new System.Windows.Forms.Button();
            this.btnNewOrderCancel = new System.Windows.Forms.Button();
            this.btnNewOrderUpdate = new System.Windows.Forms.Button();
            this.btnExistingOrderUpdate = new System.Windows.Forms.Button();
            this.btnExistingOrderEdit = new System.Windows.Forms.Button();
            this.btnExistingOrderCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVOrders
            // 
            this.dGVOrders.AllowUserToAddRows = false;
            this.dGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Supplier,
            this.PlaceDate,
            this.OrderState,
            this.DeliveryDate,
            this.SpecialNotes});
            this.dGVOrders.Location = new System.Drawing.Point(35, 220);
            this.dGVOrders.Name = "dGVOrders";
            this.dGVOrders.Size = new System.Drawing.Size(505, 192);
            this.dGVOrders.TabIndex = 0;
            this.dGVOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVOrders_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "SupplierName";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // PlaceDate
            // 
            this.PlaceDate.DataPropertyName = "PlaceDate";
            this.PlaceDate.HeaderText = "PlaceDate";
            this.PlaceDate.Name = "PlaceDate";
            this.PlaceDate.ReadOnly = true;
            // 
            // OrderState
            // 
            this.OrderState.DataPropertyName = "OrderState";
            this.OrderState.HeaderText = "State";
            this.OrderState.Name = "OrderState";
            this.OrderState.ReadOnly = true;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            this.DeliveryDate.HeaderText = "DeliveryDate";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            // 
            // SpecialNotes
            // 
            this.SpecialNotes.DataPropertyName = "SpecialNotes";
            this.SpecialNotes.HeaderText = "SpecialNotes";
            this.SpecialNotes.Name = "SpecialNotes";
            this.SpecialNotes.ReadOnly = true;
            // 
            // dGVOrderItems
            // 
            this.dGVOrderItems.AllowUserToAddRows = false;
            this.dGVOrderItems.AllowUserToDeleteRows = false;
            this.dGVOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Quantity,
            this.Price,
            this.OrderItemId});
            this.dGVOrderItems.Location = new System.Drawing.Point(590, 220);
            this.dGVOrderItems.Name = "dGVOrderItems";
            this.dGVOrderItems.ReadOnly = true;
            this.dGVOrderItems.Size = new System.Drawing.Size(408, 192);
            this.dGVOrderItems.TabIndex = 0;
            this.dGVOrderItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVOrderItems_CellDoubleClick);
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // OrderItemId
            // 
            this.OrderItemId.DataPropertyName = "ProductId";
            this.OrderItemId.HeaderText = "Id";
            this.OrderItemId.Name = "OrderItemId";
            this.OrderItemId.ReadOnly = true;
            this.OrderItemId.Visible = false;
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
            this.comboBxOrderState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.dTPPlaceDate.CustomFormat = " ";
            this.dTPPlaceDate.Enabled = false;
            this.dTPPlaceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPPlaceDate.Location = new System.Drawing.Point(408, 53);
            this.dTPPlaceDate.Name = "dTPPlaceDate";
            this.dTPPlaceDate.Size = new System.Drawing.Size(121, 20);
            this.dTPPlaceDate.TabIndex = 4;
            this.dTPPlaceDate.ValueChanged += new System.EventHandler(this.dTPPlaceDate_ValueChanged);
            this.dTPPlaceDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dTPPlaceDate_KeyDown);
            // 
            // dTPDeliveryDate
            // 
            this.dTPDeliveryDate.CustomFormat = " ";
            this.dTPDeliveryDate.Enabled = false;
            this.dTPDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDeliveryDate.Location = new System.Drawing.Point(408, 78);
            this.dTPDeliveryDate.Name = "dTPDeliveryDate";
            this.dTPDeliveryDate.Size = new System.Drawing.Size(121, 20);
            this.dTPDeliveryDate.TabIndex = 4;
            this.dTPDeliveryDate.ValueChanged += new System.EventHandler(this.dTPDeliveryDate_ValueChanged);
            this.dTPDeliveryDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dTPDeliveryDate_KeyDown);
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
            // comboBxSupplier
            // 
            this.comboBxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxSupplier.Enabled = false;
            this.comboBxSupplier.FormattingEnabled = true;
            this.comboBxSupplier.Location = new System.Drawing.Point(146, 111);
            this.comboBxSupplier.Name = "comboBxSupplier";
            this.comboBxSupplier.Size = new System.Drawing.Size(121, 21);
            this.comboBxSupplier.TabIndex = 3;
            this.comboBxSupplier.SelectedValueChanged += new System.EventHandler(this.comboBxSupplier_SelectedValueChanged);
            // 
            // lblOrderItemName
            // 
            this.lblOrderItemName.AutoSize = true;
            this.lblOrderItemName.Location = new System.Drawing.Point(747, 55);
            this.lblOrderItemName.Name = "lblOrderItemName";
            this.lblOrderItemName.Size = new System.Drawing.Size(35, 13);
            this.lblOrderItemName.TabIndex = 1;
            this.lblOrderItemName.Text = "Name";
            // 
            // comboBxOrderItemName
            // 
            this.comboBxOrderItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxOrderItemName.Enabled = false;
            this.comboBxOrderItemName.FormattingEnabled = true;
            this.comboBxOrderItemName.Location = new System.Drawing.Point(817, 52);
            this.comboBxOrderItemName.Name = "comboBxOrderItemName";
            this.comboBxOrderItemName.Size = new System.Drawing.Size(121, 21);
            this.comboBxOrderItemName.TabIndex = 3;
            this.comboBxOrderItemName.SelectedValueChanged += new System.EventHandler(this.comboBxOrderItemName_SelectedValueChanged);
            // 
            // lblOrderItemQuantity
            // 
            this.lblOrderItemQuantity.AutoSize = true;
            this.lblOrderItemQuantity.Location = new System.Drawing.Point(736, 87);
            this.lblOrderItemQuantity.Name = "lblOrderItemQuantity";
            this.lblOrderItemQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblOrderItemQuantity.TabIndex = 1;
            this.lblOrderItemQuantity.Text = "Quantity";
            // 
            // txtBxOrderItemQuantity
            // 
            this.txtBxOrderItemQuantity.Enabled = false;
            this.txtBxOrderItemQuantity.Location = new System.Drawing.Point(817, 84);
            this.txtBxOrderItemQuantity.Name = "txtBxOrderItemQuantity";
            this.txtBxOrderItemQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBxOrderItemQuantity.TabIndex = 2;
            this.txtBxOrderItemQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxOrderItemQuantity_KeyPress);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(747, 113);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(31, 13);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "Price";
            // 
            // txtBxOrderItemPrice
            // 
            this.txtBxOrderItemPrice.Enabled = false;
            this.txtBxOrderItemPrice.Location = new System.Drawing.Point(817, 110);
            this.txtBxOrderItemPrice.Name = "txtBxOrderItemPrice";
            this.txtBxOrderItemPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBxOrderItemPrice.TabIndex = 2;
            // 
            // btnNewOrderCreate
            // 
            this.btnNewOrderCreate.Location = new System.Drawing.Point(79, 165);
            this.btnNewOrderCreate.Name = "btnNewOrderCreate";
            this.btnNewOrderCreate.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrderCreate.TabIndex = 5;
            this.btnNewOrderCreate.Text = "Create";
            this.btnNewOrderCreate.UseVisualStyleBackColor = true;
            this.btnNewOrderCreate.Click += new System.EventHandler(this.btnOrderNewCreate_Click);
            // 
            // btnOrderItemAdd
            // 
            this.btnOrderItemAdd.Enabled = false;
            this.btnOrderItemAdd.Location = new System.Drawing.Point(621, 165);
            this.btnOrderItemAdd.Name = "btnOrderItemAdd";
            this.btnOrderItemAdd.Size = new System.Drawing.Size(75, 23);
            this.btnOrderItemAdd.TabIndex = 6;
            this.btnOrderItemAdd.Text = "Add";
            this.btnOrderItemAdd.UseVisualStyleBackColor = true;
            this.btnOrderItemAdd.Click += new System.EventHandler(this.btnOrderItemAdd_Click);
            // 
            // btnOrderItemEdit
            // 
            this.btnOrderItemEdit.Enabled = false;
            this.btnOrderItemEdit.Location = new System.Drawing.Point(717, 165);
            this.btnOrderItemEdit.Name = "btnOrderItemEdit";
            this.btnOrderItemEdit.Size = new System.Drawing.Size(75, 23);
            this.btnOrderItemEdit.TabIndex = 7;
            this.btnOrderItemEdit.Text = "Edit";
            this.btnOrderItemEdit.UseVisualStyleBackColor = true;
            this.btnOrderItemEdit.Click += new System.EventHandler(this.btnOrderItemEdit_Click);
            // 
            // btnOrderItemRemove
            // 
            this.btnOrderItemRemove.Enabled = false;
            this.btnOrderItemRemove.Location = new System.Drawing.Point(817, 165);
            this.btnOrderItemRemove.Name = "btnOrderItemRemove";
            this.btnOrderItemRemove.Size = new System.Drawing.Size(75, 23);
            this.btnOrderItemRemove.TabIndex = 7;
            this.btnOrderItemRemove.Text = "Remove";
            this.btnOrderItemRemove.UseVisualStyleBackColor = true;
            this.btnOrderItemRemove.Click += new System.EventHandler(this.btnOrderItemRemove_Click);
            // 
            // btnOrderItemUpdate
            // 
            this.btnOrderItemUpdate.Enabled = false;
            this.btnOrderItemUpdate.Location = new System.Drawing.Point(817, 165);
            this.btnOrderItemUpdate.Name = "btnOrderItemUpdate";
            this.btnOrderItemUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnOrderItemUpdate.TabIndex = 8;
            this.btnOrderItemUpdate.Text = "Update";
            this.btnOrderItemUpdate.UseVisualStyleBackColor = true;
            this.btnOrderItemUpdate.Visible = false;
            this.btnOrderItemUpdate.Click += new System.EventHandler(this.btnOrderItemUpdate_Click);
            // 
            // btnOrderItemCancel
            // 
            this.btnOrderItemCancel.Enabled = false;
            this.btnOrderItemCancel.Location = new System.Drawing.Point(935, 165);
            this.btnOrderItemCancel.Name = "btnOrderItemCancel";
            this.btnOrderItemCancel.Size = new System.Drawing.Size(75, 23);
            this.btnOrderItemCancel.TabIndex = 9;
            this.btnOrderItemCancel.Text = "Cancel";
            this.btnOrderItemCancel.UseVisualStyleBackColor = true;
            this.btnOrderItemCancel.Click += new System.EventHandler(this.btnOrderItemCancel_Click);
            // 
            // btnNewOrderCancel
            // 
            this.btnNewOrderCancel.Enabled = false;
            this.btnNewOrderCancel.Location = new System.Drawing.Point(351, 165);
            this.btnNewOrderCancel.Name = "btnNewOrderCancel";
            this.btnNewOrderCancel.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrderCancel.TabIndex = 5;
            this.btnNewOrderCancel.Text = "Cancel";
            this.btnNewOrderCancel.UseVisualStyleBackColor = true;
            this.btnNewOrderCancel.Click += new System.EventHandler(this.btnNewOrderCancel_Click);
            // 
            // btnNewOrderUpdate
            // 
            this.btnNewOrderUpdate.Enabled = false;
            this.btnNewOrderUpdate.Location = new System.Drawing.Point(173, 165);
            this.btnNewOrderUpdate.Name = "btnNewOrderUpdate";
            this.btnNewOrderUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrderUpdate.TabIndex = 10;
            this.btnNewOrderUpdate.Text = "Update";
            this.btnNewOrderUpdate.UseVisualStyleBackColor = true;
            this.btnNewOrderUpdate.Click += new System.EventHandler(this.btnNewOrderUpdate_Click);
            // 
            // btnExistingOrderUpdate
            // 
            this.btnExistingOrderUpdate.Enabled = false;
            this.btnExistingOrderUpdate.Location = new System.Drawing.Point(173, 165);
            this.btnExistingOrderUpdate.Name = "btnExistingOrderUpdate";
            this.btnExistingOrderUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnExistingOrderUpdate.TabIndex = 10;
            this.btnExistingOrderUpdate.Text = "Update";
            this.btnExistingOrderUpdate.UseVisualStyleBackColor = true;
            this.btnExistingOrderUpdate.Click += new System.EventHandler(this.btnExistingOrderUpdate_Click);
            // 
            // btnExistingOrderEdit
            // 
            this.btnExistingOrderEdit.Enabled = false;
            this.btnExistingOrderEdit.Location = new System.Drawing.Point(270, 165);
            this.btnExistingOrderEdit.Name = "btnExistingOrderEdit";
            this.btnExistingOrderEdit.Size = new System.Drawing.Size(75, 23);
            this.btnExistingOrderEdit.TabIndex = 11;
            this.btnExistingOrderEdit.Text = "Edit";
            this.btnExistingOrderEdit.UseVisualStyleBackColor = true;
            this.btnExistingOrderEdit.Click += new System.EventHandler(this.btnExistingOrderEdit_Click);
            // 
            // btnExistingOrderCancel
            // 
            this.btnExistingOrderCancel.Enabled = false;
            this.btnExistingOrderCancel.Location = new System.Drawing.Point(351, 165);
            this.btnExistingOrderCancel.Name = "btnExistingOrderCancel";
            this.btnExistingOrderCancel.Size = new System.Drawing.Size(75, 23);
            this.btnExistingOrderCancel.TabIndex = 5;
            this.btnExistingOrderCancel.Text = "Cancel";
            this.btnExistingOrderCancel.UseVisualStyleBackColor = true;
            this.btnExistingOrderCancel.Click += new System.EventHandler(this.btnExistingOrderCancel_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 445);
            this.Controls.Add(this.btnExistingOrderEdit);
            this.Controls.Add(this.btnExistingOrderUpdate);
            this.Controls.Add(this.btnNewOrderUpdate);
            this.Controls.Add(this.btnOrderItemRemove);
            this.Controls.Add(this.btnOrderItemCancel);
            this.Controls.Add(this.btnOrderItemEdit);
            this.Controls.Add(this.btnOrderItemAdd);
            this.Controls.Add(this.btnExistingOrderCancel);
            this.Controls.Add(this.btnNewOrderCancel);
            this.Controls.Add(this.btnNewOrderCreate);
            this.Controls.Add(this.dTPDeliveryDate);
            this.Controls.Add(this.dTPPlaceDate);
            this.Controls.Add(this.comboBxOrderItemName);
            this.Controls.Add(this.comboBxSupplier);
            this.Controls.Add(this.comboBxOrderState);
            this.Controls.Add(this.txtBxSpecialNote);
            this.Controls.Add(this.txtBxOrderItemQuantity);
            this.Controls.Add(this.txtBxOrderItemPrice);
            this.Controls.Add(this.lblOrderItemName);
            this.Controls.Add(this.txtBxOrderId);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblOrderState);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblOrderItemQuantity);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblPlaceDate);
            this.Controls.Add(this.lblSpecialNote);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.dGVOrderItems);
            this.Controls.Add(this.dGVOrders);
            this.Controls.Add(this.btnOrderItemUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVOrders;
        private System.Windows.Forms.DataGridView dGVOrderItems;
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
        private System.Windows.Forms.ComboBox comboBxSupplier;
        private System.Windows.Forms.Label lblOrderItemName;
        private System.Windows.Forms.ComboBox comboBxOrderItemName;
        private System.Windows.Forms.Label lblOrderItemQuantity;
        private System.Windows.Forms.TextBox txtBxOrderItemQuantity;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtBxOrderItemPrice;
        private System.Windows.Forms.Button btnNewOrderCreate;
        private System.Windows.Forms.Button btnOrderItemAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemId;
        private System.Windows.Forms.Button btnOrderItemEdit;
        private System.Windows.Forms.Button btnOrderItemRemove;
        private System.Windows.Forms.Button btnOrderItemUpdate;
        private System.Windows.Forms.Button btnOrderItemCancel;
        private System.Windows.Forms.Button btnNewOrderCancel;
        private System.Windows.Forms.Button btnNewOrderUpdate;
        private System.Windows.Forms.Button btnExistingOrderUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderState;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialNotes;
        private System.Windows.Forms.Button btnExistingOrderEdit;
        private System.Windows.Forms.Button btnExistingOrderCancel;
    }
}