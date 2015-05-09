using Coupon.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupon.business_layer
{
    static class Login
    {
        public static  User LoginUser(string username,string userPassword)
        {
            User user=UserDB.GetUserPassword(username);
            if (user!=null)
            {
                if (userPassword == user.Password)
                    return user; 
            }

            return null;
        }
    }
}
