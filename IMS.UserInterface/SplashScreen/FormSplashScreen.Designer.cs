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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplashScreen));
            this.pnlLeftContainer = new System.Windows.Forms.Panel();
            this.picBxLeftPanel = new System.Windows.Forms.PictureBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblActiveUserFirstName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.pnlLeftContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLeftPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftContainer
            // 
            this.pnlLeftContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlLeftContainer.Controls.Add(this.picBxLeftPanel);
            this.pnlLeftContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftContainer.Name = "pnlLeftContainer";
            this.pnlLeftContainer.Size = new System.Drawing.Size(325, 313);
            this.pnlLeftContainer.TabIndex = 1;
            // 
            // picBxLeftPanel
            // 
            this.picBxLeftPanel.Image = ((System.Drawing.Image)(resources.GetObject("picBxLeftPanel.Image")));
            this.picBxLeftPanel.Location = new System.Drawing.Point(32, 18);
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
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblGreeting.Location = new System.Drawing.Point(518, 9);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(137, 33);
            this.lblGreeting.TabIndex = 2;
            this.lblGreeting.Text = "Welcome";
            // 
            // lblActiveUserFirstName
            // 
            this.lblActiveUserFirstName.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lblActiveUserFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUserFirstName.ForeColor = System.Drawing.Color.Gray;
            this.lblActiveUserFirstName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblActiveUserFirstName.Location = new System.Drawing.Point(479, 60);
            this.lblActiveUserFirstName.Name = "lblActiveUserFirstName";
            this.lblActiveUserFirstName.Size = new System.Drawing.Size(214, 34);
            this.lblActiveUserFirstName.TabIndex = 3;
            this.lblActiveUserFirstName.Text = "ActiveUserFirstName";
            this.lblActiveUserFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Silver;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(505, 134);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "%";
            this.circularProgressBar1.TabIndex = 4;
            this.circularProgressBar1.Text = "0";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // FormSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(844, 313);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.lblActiveUserFirstName);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.pnlLeftContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplashScreen";
            this.Load += new System.EventHandler(this.FormSplashScreen_Load);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}