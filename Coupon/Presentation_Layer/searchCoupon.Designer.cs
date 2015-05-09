namespace Coupon.Presentation_Layer
{
    partial class searchCoupon
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.cb_location = new System.Windows.Forms.CheckBox();
            this.lbl_preference = new System.Windows.Forms.Label();
            this.combo_preference = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_title.Location = new System.Drawing.Point(15, 26);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(238, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Search Your Coupon!";
            // 
            // cb_location
            // 
            this.cb_location.AutoSize = true;
            this.cb_location.Location = new System.Drawing.Point(31, 132);
            this.cb_location.Name = "cb_location";
            this.cb_location.Size = new System.Drawing.Size(82, 17);
            this.cb_location.TabIndex = 1;
            this.cb_location.Text = "By Location";
            this.cb_location.UseVisualStyleBackColor = true;
            // 
            // lbl_preference
            // 
            this.lbl_preference.AutoSize = true;
            this.lbl_preference.Location = new System.Drawing.Point(31, 85);
            this.lbl_preference.Name = "lbl_preference";
            this.lbl_preference.Size = new System.Drawing.Size(59, 13);
            this.lbl_preference.TabIndex = 2;
            this.lbl_preference.Text = "Preference";
            // 
            // combo_preference
            // 
            this.combo_preference.FormattingEnabled = true;
            this.combo_preference.Location = new System.Drawing.Point(110, 82);
            this.combo_preference.Name = "combo_preference";
            this.combo_preference.Size = new System.Drawing.Size(121, 21);
            this.combo_preference.TabIndex = 3;
            this.combo_preference.SelectedIndexChanged += new System.EventHandler(this.combo_preference_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(34, 187);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search!";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // searchCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.combo_preference);
            this.Controls.Add(this.lbl_preference);
            this.Controls.Add(this.cb_location);
            this.Controls.Add(this.lbl_title);
            this.Name = "searchCoupon";
            this.Size = new System.Drawing.Size(422, 327);
            this.Load += new System.EventHandler(this.searchCoupon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.CheckBox cb_location;
        private System.Windows.Forms.Label lbl_preference;
        private System.Windows.Forms.ComboBox combo_preference;
        private System.Windows.Forms.Button btn_search;
    }
}
