using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coupon.Presentation_Layer
{
    public partial class WelcomeControl : UserControl
    {
        public WelcomeControl()
        {
            InitializeComponent();
        }
        public void fill(User user)
        {
            lbl_hello.Text="hello "+ user.Name;
            lbl_LoginHour.Text="Last Login at: "+DateTime.Now.ToString();
        }
    }
}
