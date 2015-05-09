using Coupon.business_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coupon.Presentation_Layer
{
    public partial class Coupon4U : Form
    {
        public Coupon4U()
        {
            InitializeComponent();
        }

        private void Coupon4U_Load(object sender, EventArgs e)
        {
            loginControl1.DataAvailable += new EventHandler(Login_DataAvailable);
            welcomeControl1.Visible = false;
            searchCoupon1.Visible = false;
        }

        private void Login_DataAvailable(object sender, EventArgs e)
        {
            loginControl1.Visible = false;
            welcomeControl1.Visible = true;
            searchCoupon1.Visible = true;
            welcomeControl1.fill(loginControl1.LoginUser);
        }

    }
}
