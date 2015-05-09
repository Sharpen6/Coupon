using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupon.Data_Layer
{
    static class UserDB
    {
        public static User GetUserPassword(string username)
        {
            try
            {
                using (basicEntities be = new basicEntities())
                {

                    User user = be.Users.Find(username);
                    return user;
                }
            }
            catch
            {
                return null;
            }

        }
    }
}
