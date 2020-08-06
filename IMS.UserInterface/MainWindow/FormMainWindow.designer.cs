namespace IMS.UserInterface
{
    partial class FormMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainWindow));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMaximizer = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.PictureBox();
            this.panelVerticalMenu = new System.Windows.Forms.Panel();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.BtnMenuSlider = new System.Windows.Forms.PictureBox();
            this.btnMenuExpander = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.PictureBox();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
            this.panelVerticalMenu.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenuSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuExpander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(99)))), ((int)(((byte)(196)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.btnMaximizer);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnRestore);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1300, 30);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(616, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 20);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Inventory Managment System";
            // 
            // btnMaximizer
            // 
            this.btnMaximizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizer.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizer.Image")));
            this.btnMaximizer.Location = new System.Drawing.Point(1241, 2);
            this.btnMaximizer.Name = "btnMaximizer";
            this.btnMaximizer.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizer.TabIndex = 3;
            this.btnMaximizer.TabStop = false;
            this.btnMaximizer.Click += new System.EventHandler(this.BtnMaximizer_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Image = global::IMS.UserInterface.Properties.Resources.Minimize;
            this.btnMinimize.Location = new System.Drawing.Point(1210, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::IMS.UserInterface.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(1272, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Image = global::IMS.UserInterface.Properties.Resources.Restore;
            this.btnRestore.Location = new System.Drawing.Point(1241, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(25, 25);
            this.btnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestore.TabIndex = 4;
            this.btnRestore.TabStop = false;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // panelVerticalMenu
            // 
            this.panelVerticalMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelVerticalMenu.Controls.Add(this.btnEmployees);
            this.panelVerticalMenu.Controls.Add(this.panelUserInfo);
            this.panelVerticalMenu.Controls.Add(this.btnOrders);
            this.panelVerticalMenu.Controls.Add(this.btnInventory);
            this.panelVerticalMenu.Controls.Add(this.btnCategories);
            this.panelVerticalMenu.Controls.Add(this.btnSuppliers);
            this.panelVerticalMenu.Controls.Add(this.btnProducts);
            this.panelVerticalMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVerticalMenu.Location = new System.Drawing.Point(0, 30);
            this.panelVerticalMenu.Name = "panelVerticalMenu";
            this.panelVerticalMenu.Size = new System.Drawing.Size(250, 523);
            this.panelVerticalMenu.TabIndex = 0;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Image = global::IMS.UserInterface.Properties.Resources.Employees;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 380);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(250, 40);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "                Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.BtnMenuSlider);
            this.panelUserInfo.Controls.Add(this.btnMenuExpander);
            this.panelUserInfo.Controls.Add(this.lblEmail);
            this.panelUserInfo.Controls.Add(this.lblFirstName);
            this.panelUserInfo.Controls.Add(this.lblRole);
            this.panelUserInfo.Controls.Add(this.btnProfile);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(250, 100);
            this.panelUserInfo.TabIndex = 1;
            // 
            // BtnMenuSlider
            // 
            this.BtnMenuSlider.Image = global::IMS.UserInterface.Properties.Resources.Menu_Slider;
            this.BtnMenuSlider.Location = new System.Drawing.Point(210, 7);
            this.BtnMenuSlider.Name = "BtnMenuSlider";
            this.BtnMenuSlider.Size = new System.Drawing.Size(34, 27);
            this.BtnMenuSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenuSlider.TabIndex = 4;
            this.BtnMenuSlider.TabStop = false;
            this.BtnMenuSlider.Click += new System.EventHandler(this.BtnMenuSlider_Click);
            // 
            // btnMenuExpander
            // 
            this.btnMenuExpander.Image = global::IMS.UserInterface.Properties.Resources.right;
            this.btnMenuExpander.Location = new System.Drawing.Point(23, 6);
            this.btnMenuExpander.Name = "btnMenuExpander";
            this.btnMenuExpander.Size = new System.Drawing.Size(34, 27);
            this.btnMenuExpander.TabIndex = 3;
            this.btnMenuExpander.TabStop = false;
            this.btnMenuExpander.Visible = false;
            this.btnMenuExpander.Click += new System.EventHandler(this.BtnMenuExpander_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(90, 77);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(90, 55);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(90, 31);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            // 
            // btnProfile
            // 
            this.btnProfile.Image = global::IMS.UserInterface.Properties.Resources.DefaultUserPic;
            this.btnProfile.Location = new System.Drawing.Point(3, 31);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(68, 50);
            this.btnProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProfile.TabIndex = 1;
            this.btnProfile.TabStop = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 196);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOrders.Size = new System.Drawing.Size(250, 40);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "                Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::IMS.UserInterface.Properties.Resources.Inventory;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 150);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(250, 40);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "                Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Image = global::IMS.UserInterface.Properties.Resources.Category;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(3, 334);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(247, 40);
            this.btnCategories.TabIndex = 3;
            this.btnCategories.Text = "               Categories";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.BtnCategories_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.Image = global::IMS.UserInterface.Properties.Resources.Supplier;
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 288);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSuppliers.Size = new System.Drawing.Size(250, 40);
            this.btnSuppliers.TabIndex = 2;
            this.btnSuppliers.Text = "                Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.BtnSuppliers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 242);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(250, 40);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "                Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 30);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1050, 523);
            this.panelContainer.TabIndex = 2;
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 553);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelVerticalMenu);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindowForm";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
            this.panelVerticalMenu.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenuSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuExpander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox btnMaximizer;
        private System.Windows.Forms.PictureBox btnMinimize;
        internal System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnRestore;
        private System.Windows.Forms.Panel panelVerticalMenu;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.PictureBox BtnMenuSlider;
        private System.Windows.Forms.PictureBox btnMenuExpander;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnProfile;
    }
}