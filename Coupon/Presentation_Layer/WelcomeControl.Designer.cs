namespace Coupon.Presentation_Layer
{
    partial class WelcomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_hello = new System.Windows.Forms.Label();
            this.lbl_LoginHour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Location = new System.Drawing.Point(7, 7);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(58, 13);
            this.lbl_hello.TabIndex = 0;
            this.lbl_hello.Text = "user Name";
            // 
            // lbl_LoginHour
            // 
            this.lbl_LoginHour.AutoSize = true;
            this.lbl_LoginHour.Location = new System.Drawing.Point(98, 7);
            this.lbl_LoginHour.Name = "lbl_LoginHour";
            this.lbl_LoginHour.Size = new System.Drawing.Size(53, 13);
            this.lbl_LoginHour.TabIndex = 1;
            this.lbl_LoginHour.Text = "Date.now";
            // 
            // WelcomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_LoginHour);
            this.Controls.Add(this.lbl_hello);
            this.Name = "WelcomeControl";
            this.Size = new System.Drawing.Size(342, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.Label lbl_LoginHour;
    }
}
