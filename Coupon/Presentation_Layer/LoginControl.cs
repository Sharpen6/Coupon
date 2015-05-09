using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coupon.business_layer;

namespace Coupon.Presentation_Layer
{
    public partial class LoginControl : UserControl
    {
        public User LoginUser;
        public event EventHandler DataAvailable;
        protected virtual void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        public LoginControl()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginUser  = Login.LoginUser(txt_UserName.Text, txt_password.Text);
            if (LoginUser != null)
                OnDataAvailable(null);
            else
            {
                MessageBox.Show("wrong UserName or Password");
                txt_password.Text = "";
                txt_UserName.Text = "";
            }
        }
    }
}
