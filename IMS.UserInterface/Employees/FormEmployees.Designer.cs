namespace IMS.UserInterface.Employees
{
    partial class FormEmployees
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
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtBxEmployeeId = new System.Windows.Forms.TextBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dTPDOB = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBxAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPJoinedDate = new System.Windows.Forms.DateTimePicker();
            this.lblAccountId = new System.Windows.Forms.Label();
            this.txtBxAccountId = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtBxEmailAddress = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.blPassword = new System.Windows.Forms.Label();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.lblAccountState = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.comboBxAccountState = new System.Windows.Forms.ComboBox();
            this.comboBxRole = new System.Windows.Forms.ComboBox();
            this.dGVEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(122, 57);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(65, 13);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // txtBxEmployeeId
            // 
            this.txtBxEmployeeId.Location = new System.Drawing.Point(193, 54);
            this.txtBxEmployeeId.Name = "txtBxEmployeeId";
            this.txtBxEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.txtBxEmployeeId.TabIndex = 1;
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(193, 88);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBxFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(122, 91);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(122, 120);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(193, 117);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtBxLastName.TabIndex = 1;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(340, 57);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(68, 13);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // dTPDOB
            // 
            this.dTPDOB.CustomFormat = "dd-MM-yyyy";
            this.dTPDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDOB.Location = new System.Drawing.Point(414, 57);
            this.dTPDOB.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dTPDOB.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dTPDOB.Name = "dTPDOB";
            this.dTPDOB.Size = new System.Drawing.Size(97, 20);
            this.dTPDOB.TabIndex = 2;
            this.dTPDOB.Value = new System.DateTime(2020, 7, 7, 0, 0, 0, 0);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(340, 147);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // txtBxAdress
            // 
            this.txtBxAdress.Location = new System.Drawing.Point(414, 144);
            this.txtBxAdress.Name = "txtBxAdress";
            this.txtBxAdress.Size = new System.Drawing.Size(100, 20);
            this.txtBxAdress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joined Date";
            // 
            // dTPJoinedDate
            // 
            this.dTPJoinedDate.CustomFormat = "dd-MM-yyyy";
            this.dTPJoinedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPJoinedDate.Location = new System.Drawing.Point(414, 94);
            this.dTPJoinedDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dTPJoinedDate.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dTPJoinedDate.Name = "dTPJoinedDate";
            this.dTPJoinedDate.Size = new System.Drawing.Size(97, 20);
            this.dTPJoinedDate.TabIndex = 2;
            this.dTPJoinedDate.Value = new System.DateTime(2020, 7, 7, 0, 0, 0, 0);
            // 
            // lblAccountId
            // 
            this.lblAccountId.AutoSize = true;
            this.lblAccountId.Location = new System.Drawing.Point(685, 54);
            this.lblAccountId.Name = "lblAccountId";
            this.lblAccountId.Size = new System.Drawing.Size(59, 13);
            this.lblAccountId.TabIndex = 0;
            this.lblAccountId.Text = "Account Id";
            // 
            // txtBxAccountId
            // 
            this.txtBxAccountId.Location = new System.Drawing.Point(764, 51);
            this.txtBxAccountId.Name = "txtBxAccountId";
            this.txtBxAccountId.Size = new System.Drawing.Size(121, 20);
            this.txtBxAccountId.TabIndex = 1;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(122, 147);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(32, 13);
            this.lblEmailAddress.TabIndex = 0;
            this.lblEmailAddress.Text = "Email";
            // 
            // txtBxEmailAddress
            // 
            this.txtBxEmailAddress.Location = new System.Drawing.Point(193, 144);
            this.txtBxEmailAddress.Name = "txtBxEmailAddress";
            this.txtBxEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBxEmailAddress.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(689, 86);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Location = new System.Drawing.Point(764, 82);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(121, 20);
            this.txtBxUsername.TabIndex = 1;
            // 
            // blPassword
            // 
            this.blPassword.AutoSize = true;
            this.blPassword.Location = new System.Drawing.Point(691, 109);
            this.blPassword.Name = "blPassword";
            this.blPassword.Size = new System.Drawing.Size(53, 13);
            this.blPassword.TabIndex = 0;
            this.blPassword.Text = "Password";
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(764, 109);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(121, 20);
            this.txtBxPassword.TabIndex = 1;
            // 
            // lblAccountState
            // 
            this.lblAccountState.AutoSize = true;
            this.lblAccountState.Location = new System.Drawing.Point(669, 172);
            this.lblAccountState.Name = "lblAccountState";
            this.lblAccountState.Size = new System.Drawing.Size(75, 13);
            this.lblAccountState.TabIndex = 0;
            this.lblAccountState.Text = "Account State";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(715, 141);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role";
            // 
            // comboBxAccountState
            // 
            this.comboBxAccountState.FormattingEnabled = true;
            this.comboBxAccountState.Location = new System.Drawing.Point(764, 172);
            this.comboBxAccountState.Name = "comboBxAccountState";
            this.comboBxAccountState.Size = new System.Drawing.Size(121, 21);
            this.comboBxAccountState.TabIndex = 3;
            // 
            // comboBxRole
            // 
            this.comboBxRole.FormattingEnabled = true;
            this.comboBxRole.Location = new System.Drawing.Point(764, 138);
            this.comboBxRole.Name = "comboBxRole";
            this.comboBxRole.Size = new System.Drawing.Size(121, 21);
            this.comboBxRole.TabIndex = 3;
            // 
            // dGVEmployees
            // 
            this.dGVEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEmployees.Location = new System.Drawing.Point(34, 245);
            this.dGVEmployees.Name = "dGVEmployees";
            this.dGVEmployees.Size = new System.Drawing.Size(937, 150);
            this.dGVEmployees.TabIndex = 4;
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 445);
            this.Controls.Add(this.dGVEmployees);
            this.Controls.Add(this.comboBxRole);
            this.Controls.Add(this.comboBxAccountState);
            this.Controls.Add(this.dTPJoinedDate);
            this.Controls.Add(this.dTPDOB);
            this.Controls.Add(this.txtBxAdress);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.txtBxEmailAddress);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.txtBxAccountId);
            this.Controls.Add(this.txtBxEmployeeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblAccountState);
            this.Controls.Add(this.blPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblAccountId);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmployeeId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployees";
            this.Text = "FormEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtBxEmployeeId;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dTPDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBxAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPJoinedDate;
        private System.Windows.Forms.Label lblAccountId;
        private System.Windows.Forms.TextBox txtBxAccountId;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtBxEmailAddress;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.Label blPassword;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label lblAccountState;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox comboBxAccountState;
        private System.Windows.Forms.ComboBox comboBxRole;
        private System.Windows.Forms.DataGridView dGVEmployees;
    }
}