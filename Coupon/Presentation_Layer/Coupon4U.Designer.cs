namespace Coupon.Presentation_Layer
{
    partial class Coupon4U
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
            this.loginControl1 = new LoginControl();
            this.welcomeControl1 = new WelcomeControl();
            this.searchCoupon1 = new searchCoupon();
            this.SuspendLayout();
            // 
            // loginControl1
            // 
            this.loginControl1.Location = new System.Drawing.Point(49, 14);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(211, 167);
            this.loginControl1.TabIndex = 0;
            // 
            // welcomeControl1
            // 
            this.welcomeControl1.Location = new System.Drawing.Point(49, 14);
            this.welcomeControl1.Name = "welcomeControl1";
            this.welcomeControl1.Size = new System.Drawing.Size(342, 27);
            this.welcomeControl1.TabIndex = 1;
            // 
            // searchCoupon1
            // 
            this.searchCoupon1.Location = new System.Drawing.Point(21, 36);
            this.searchCoupon1.Name = "searchCoupon1";
            this.searchCoupon1.Size = new System.Drawing.Size(422, 327);
            this.searchCoupon1.TabIndex = 2;
            // 
            // Coupon4U
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 399);
            this.Controls.Add(this.searchCoupon1);
            this.Controls.Add(this.welcomeControl1);
            this.Controls.Add(this.loginControl1);
            this.Name = "Coupon4U";
            this.Text = "Coupon4U";
            this.Load += new System.EventHandler(this.Coupon4U_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LoginControl loginControl1;
        private WelcomeControl welcomeControl1;
        private searchCoupon searchCoupon1;
    }
}