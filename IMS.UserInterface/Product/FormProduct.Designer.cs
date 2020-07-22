namespace IMS.UserInterface.Product
{
    partial class FormProduct
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
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductWarrenty = new System.Windows.Forms.Label();
            this.lblProductState = new System.Windows.Forms.Label();
            this.lblProductSupplier = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.txtBxProductId = new System.Windows.Forms.TextBox();
            this.txtBxPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtBxProductName = new System.Windows.Forms.TextBox();
            this.txtBxProductWarrenty = new System.Windows.Forms.TextBox();
            this.txtBxProductDescription = new System.Windows.Forms.TextBox();
            this.comboBxProductState = new System.Windows.Forms.ComboBox();
            this.comboBxlProductSupplier = new System.Windows.Forms.ComboBox();
            this.comboBxlblProductCategory = new System.Windows.Forms.ComboBox();
            this.dGVProducts = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductWarrenty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.btnProductNewUpdate = new System.Windows.Forms.Button();
            this.btnProductExistingUpdate = new System.Windows.Forms.Button();
            this.btnProductReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(57, 29);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(53, 13);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "ProductId";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(554, 91);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(79, 13);
            this.lblPurchasePrice.TabIndex = 0;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(57, 126);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(554, 119);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(100, 13);
            this.lblProductDescription.TabIndex = 0;
            this.lblProductDescription.Text = "Product Description";
            // 
            // lblProductWarrenty
            // 
            this.lblProductWarrenty.AutoSize = true;
            this.lblProductWarrenty.Location = new System.Drawing.Point(534, 29);
            this.lblProductWarrenty.Name = "lblProductWarrenty";
            this.lblProductWarrenty.Size = new System.Drawing.Size(90, 13);
            this.lblProductWarrenty.TabIndex = 0;
            this.lblProductWarrenty.Text = "Product Warrenty";
            // 
            // lblProductState
            // 
            this.lblProductState.AutoSize = true;
            this.lblProductState.Location = new System.Drawing.Point(534, 58);
            this.lblProductState.Name = "lblProductState";
            this.lblProductState.Size = new System.Drawing.Size(72, 13);
            this.lblProductState.TabIndex = 0;
            this.lblProductState.Text = "Product State";
            // 
            // lblProductSupplier
            // 
            this.lblProductSupplier.AutoSize = true;
            this.lblProductSupplier.Location = new System.Drawing.Point(57, 63);
            this.lblProductSupplier.Name = "lblProductSupplier";
            this.lblProductSupplier.Size = new System.Drawing.Size(85, 13);
            this.lblProductSupplier.TabIndex = 0;
            this.lblProductSupplier.Text = "Product Supplier";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(57, 91);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(89, 13);
            this.lblProductCategory.TabIndex = 0;
            this.lblProductCategory.Text = "Product Category";
            // 
            // txtBxProductId
            // 
            this.txtBxProductId.Enabled = false;
            this.txtBxProductId.Location = new System.Drawing.Point(170, 29);
            this.txtBxProductId.Name = "txtBxProductId";
            this.txtBxProductId.Size = new System.Drawing.Size(151, 20);
            this.txtBxProductId.TabIndex = 1;
            // 
            // txtBxPurchasePrice
            // 
            this.txtBxPurchasePrice.Enabled = false;
            this.txtBxPurchasePrice.Location = new System.Drawing.Point(667, 88);
            this.txtBxPurchasePrice.Name = "txtBxPurchasePrice";
            this.txtBxPurchasePrice.Size = new System.Drawing.Size(151, 20);
            this.txtBxPurchasePrice.TabIndex = 1;
            this.txtBxPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxPurchasePrice_KeyPress);
            // 
            // txtBxProductName
            // 
            this.txtBxProductName.Enabled = false;
            this.txtBxProductName.Location = new System.Drawing.Point(170, 119);
            this.txtBxProductName.Name = "txtBxProductName";
            this.txtBxProductName.Size = new System.Drawing.Size(151, 20);
            this.txtBxProductName.TabIndex = 1;
            // 
            // txtBxProductWarrenty
            // 
            this.txtBxProductWarrenty.Enabled = false;
            this.txtBxProductWarrenty.Location = new System.Drawing.Point(667, 22);
            this.txtBxProductWarrenty.Name = "txtBxProductWarrenty";
            this.txtBxProductWarrenty.Size = new System.Drawing.Size(151, 20);
            this.txtBxProductWarrenty.TabIndex = 1;
            this.txtBxProductWarrenty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxProductWarrenty_KeyPress);
            // 
            // txtBxProductDescription
            // 
            this.txtBxProductDescription.Enabled = false;
            this.txtBxProductDescription.Location = new System.Drawing.Point(667, 116);
            this.txtBxProductDescription.Name = "txtBxProductDescription";
            this.txtBxProductDescription.Size = new System.Drawing.Size(151, 20);
            this.txtBxProductDescription.TabIndex = 1;
            // 
            // comboBxProductState
            // 
            this.comboBxProductState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxProductState.Enabled = false;
            this.comboBxProductState.FormattingEnabled = true;
            this.comboBxProductState.Location = new System.Drawing.Point(667, 55);
            this.comboBxProductState.Name = "comboBxProductState";
            this.comboBxProductState.Size = new System.Drawing.Size(151, 21);
            this.comboBxProductState.TabIndex = 2;
            // 
            // comboBxlProductSupplier
            // 
            this.comboBxlProductSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxlProductSupplier.Enabled = false;
            this.comboBxlProductSupplier.FormattingEnabled = true;
            this.comboBxlProductSupplier.Location = new System.Drawing.Point(170, 60);
            this.comboBxlProductSupplier.Name = "comboBxlProductSupplier";
            this.comboBxlProductSupplier.Size = new System.Drawing.Size(151, 21);
            this.comboBxlProductSupplier.TabIndex = 2;
            // 
            // comboBxlblProductCategory
            // 
            this.comboBxlblProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxlblProductCategory.Enabled = false;
            this.comboBxlblProductCategory.FormattingEnabled = true;
            this.comboBxlblProductCategory.Location = new System.Drawing.Point(170, 88);
            this.comboBxlblProductCategory.Name = "comboBxlblProductCategory";
            this.comboBxlblProductCategory.Size = new System.Drawing.Size(151, 21);
            this.comboBxlblProductCategory.TabIndex = 2;
            // 
            // dGVProducts
            // 
            this.dGVProducts.AllowUserToAddRows = false;
            this.dGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductDescription,
            this.ProductPrice,
            this.ProductWarrenty,
            this.ProductSupplierName,
            this.ProductCategoryName,
            this.ProductState});
            this.dGVProducts.Location = new System.Drawing.Point(76, 282);
            this.dGVProducts.Name = "dGVProducts";
            this.dGVProducts.ReadOnly = true;
            this.dGVProducts.Size = new System.Drawing.Size(920, 150);
            this.dGVProducts.TabIndex = 3;
            this.dGVProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVProducts_CellDoubleClick);
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductId.DataPropertyName = "Id";
            this.ProductId.HeaderText = "Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "Name";
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductDescription
            // 
            this.ProductDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductDescription.DataPropertyName = "Description";
            this.ProductDescription.HeaderText = "Description";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductPrice.DataPropertyName = "Price";
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProductWarrenty
            // 
            this.ProductWarrenty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductWarrenty.DataPropertyName = "Warrenty";
            this.ProductWarrenty.HeaderText = "Warrenty";
            this.ProductWarrenty.Name = "ProductWarrenty";
            this.ProductWarrenty.ReadOnly = true;
            // 
            // ProductSupplierName
            // 
            this.ProductSupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductSupplierName.DataPropertyName = "SupplierName";
            this.ProductSupplierName.HeaderText = "SupplierName";
            this.ProductSupplierName.Name = "ProductSupplierName";
            this.ProductSupplierName.ReadOnly = true;
            // 
            // ProductCategoryName
            // 
            this.ProductCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCategoryName.DataPropertyName = "CategoryName";
            this.ProductCategoryName.HeaderText = "CategoryName";
            this.ProductCategoryName.Name = "ProductCategoryName";
            this.ProductCategoryName.ReadOnly = true;
            // 
            // ProductState
            // 
            this.ProductState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductState.DataPropertyName = "ProductState";
            this.ProductState.HeaderText = "State";
            this.ProductState.Name = "ProductState";
            this.ProductState.ReadOnly = true;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(888, 25);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 4;
            this.btnProductAdd.Text = "Create";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.Enabled = false;
            this.btnProductEdit.Location = new System.Drawing.Point(888, 81);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(75, 23);
            this.btnProductEdit.TabIndex = 4;
            this.btnProductEdit.Text = "Edit";
            this.btnProductEdit.UseVisualStyleBackColor = true;
            this.btnProductEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // btnProductNewUpdate
            // 
            this.btnProductNewUpdate.Location = new System.Drawing.Point(752, 181);
            this.btnProductNewUpdate.Name = "btnProductNewUpdate";
            this.btnProductNewUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnProductNewUpdate.TabIndex = 4;
            this.btnProductNewUpdate.Text = "Update";
            this.btnProductNewUpdate.UseVisualStyleBackColor = true;
            this.btnProductNewUpdate.Click += new System.EventHandler(this.btnProductNewUpdate_Click);
            // 
            // btnProductExistingUpdate
            // 
            this.btnProductExistingUpdate.Location = new System.Drawing.Point(801, 210);
            this.btnProductExistingUpdate.Name = "btnProductExistingUpdate";
            this.btnProductExistingUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnProductExistingUpdate.TabIndex = 4;
            this.btnProductExistingUpdate.Text = "Update";
            this.btnProductExistingUpdate.UseVisualStyleBackColor = true;
            this.btnProductExistingUpdate.Click += new System.EventHandler(this.btnProductExistingUpdate_Click);
            // 
            // btnProductReset
            // 
            this.btnProductReset.Location = new System.Drawing.Point(921, 181);
            this.btnProductReset.Name = "btnProductReset";
            this.btnProductReset.Size = new System.Drawing.Size(75, 23);
            this.btnProductReset.TabIndex = 4;
            this.btnProductReset.Text = "Reset";
            this.btnProductReset.UseVisualStyleBackColor = true;
            this.btnProductReset.Click += new System.EventHandler(this.btnProductReset_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 484);
            this.Controls.Add(this.btnProductReset);
            this.Controls.Add(this.btnProductExistingUpdate);
            this.Controls.Add(this.btnProductNewUpdate);
            this.Controls.Add(this.btnProductEdit);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.dGVProducts);
            this.Controls.Add(this.comboBxlblProductCategory);
            this.Controls.Add(this.comboBxlProductSupplier);
            this.Controls.Add(this.comboBxProductState);
            this.Controls.Add(this.txtBxProductDescription);
            this.Controls.Add(this.txtBxProductName);
            this.Controls.Add(this.txtBxPurchasePrice);
            this.Controls.Add(this.txtBxProductWarrenty);
            this.Controls.Add(this.txtBxProductId);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.lblProductSupplier);
            this.Controls.Add(this.lblProductState);
            this.Controls.Add(this.lblProductWarrenty);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblProductId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dGVProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductWarrenty;
        private System.Windows.Forms.Label lblProductState;
        private System.Windows.Forms.Label lblProductSupplier;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.TextBox txtBxProductId;
        private System.Windows.Forms.TextBox txtBxPurchasePrice;
        private System.Windows.Forms.TextBox txtBxProductName;
        private System.Windows.Forms.TextBox txtBxProductWarrenty;
        private System.Windows.Forms.TextBox txtBxProductDescription;
        private System.Windows.Forms.ComboBox comboBxProductState;
        private System.Windows.Forms.ComboBox comboBxlProductSupplier;
        private System.Windows.Forms.ComboBox comboBxlblProductCategory;
        private System.Windows.Forms.DataGridView dGVProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductWarrenty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductState;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.Button btnProductNewUpdate;
        private System.Windows.Forms.Button btnProductExistingUpdate;
        private System.Windows.Forms.Button btnProductReset;
    }
}