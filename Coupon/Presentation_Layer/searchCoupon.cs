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
    public partial class searchCoupon : UserControl
    {
        public searchCoupon()
        {
            InitializeComponent();
        }

        private void searchCoupon_Load(object sender, EventArgs e)
        {
            combo_preference.DataSource = Search.getCategory();
        }

        private void combo_preference_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
