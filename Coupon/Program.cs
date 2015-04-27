using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Coupon
{
    class Program
    {
        static void Main(string[] args)
        {
            using (basicEntities be = new basicEntities())
            {
                User u = new User();

                u.Name = "adam2";
                u.Password = "123123";
                u.PhoneKidomet = 054;
                u.PhoneNum = 4213456;
                u.UserName = "adam1235";
                u.Email = "adam@gmail.com";

                be.Users.Add(u);
                be.SaveChanges();
            }
        }
    }
}
