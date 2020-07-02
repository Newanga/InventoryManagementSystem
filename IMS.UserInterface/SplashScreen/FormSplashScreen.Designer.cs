namespace IMS.UserInterface.SplashScreen
{
    partial class FormSplashScreen
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
            this.pnlLeftContainer = new System.Windows.Forms.Panel();
            this.picBxLeftPanel = new System.Windows.Forms.PictureBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblActiveUserFirstName = new System.Windows.Forms.Label();
            this.pnlLeftContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLeftPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftContainer
            // 
            this.pnlLeftContainer.BackColor = System.Drawing.Color.White;
            this.pnlLeftContainer.Controls.Add(this.picBxLeftPanel);
            this.pnlLeftContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftContainer.Name = "pnlLeftContainer";
            this.pnlLeftContainer.Size = new System.Drawing.Size(325, 313);
            this.pnlLeftContainer.TabIndex = 1;
            // 
            // picBxLeftPanel
            // 
            this.picBxLeftPanel.Location = new System.Drawing.Point(33, 8);
            this.picBxLeftPanel.Name = "picBxLeftPanel";
            this.picBxLeftPanel.Size = new System.Drawing.Size(260, 277);
            this.picBxLeftPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxLeftPanel.TabIndex = 1;
            this.picBxLeftPanel.TabStop = false;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblGreeting.Location = new System.Drawing.Point(422, 71);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(126, 31);
            this.lblGreeting.TabIndex = 2;
            this.lblGreeting.Text = "Welcome";
            // 
            // lblActiveUserFirstName
            // 
            this.lblActiveUserFirstName.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lblActiveUserFirstName.AutoSize = true;
            this.lblActiveUserFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUserFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblActiveUserFirstName.Location = new System.Drawing.Point(547, 102);
            this.lblActiveUserFirstName.Name = "lblActiveUserFirstName";
            this.lblActiveUserFirstName.Size = new System.Drawing.Size(214, 25);
            this.lblActiveUserFirstName.TabIndex = 3;
            this.lblActiveUserFirstName.Text = "ActiveUserFirstName";
            // 
            // FormSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(844, 313);
            this.Controls.Add(this.lblActiveUserFirstName);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.pnlLeftContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplashScreen";
            this.pnlLeftContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLeftPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeftContainer;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblActiveUserFirstName;
        private System.Windows.Forms.PictureBox picBxLeftPanel;
    }
}