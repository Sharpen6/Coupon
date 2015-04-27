using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coupon;

namespace UnitTestProject
{
    [TestClass]
    public class TestAdmin
    {
        [TestMethod]
        public void TestAddAdmin()
        {
            using (basicEntities be = new basicEntities())
            {
                Admin A = AddAdmin("Admin123", "adam", "admin123123", 054, 3134195, "adamin@gmail.com");
                be.Users.Add(A);
                 be.SaveChanges();
                Assert.AreEqual(be.Users.Find(A.UserName).UserName, A.UserName);

            }
        }

        [TestMethod]
        public void TestRemoveAdmin()
        {
            using (basicEntities be = new basicEntities())
            {
                RemoveAdmin("Admin123");
                Assert.AreEqual(be.Users.Find("Admin123"), null);
            }
        }

        public Admin AddAdmin(string UserName, String Name, String Password, int PhoneKidumet, int PhoneNum, string Email)
        {
            using (basicEntities be = new basicEntities())
            {
                Admin u = new Admin();
                u.Name = Name;
                u.UserName = UserName;
                User sameKey = be.Users.Find(u.UserName);
                while (sameKey != null && sameKey.UserName == u.UserName)
                {
                    u.UserName += "1";
                    sameKey = be.Users.Find(u.UserName);
                }
                u.Password = Password;
                u.PhoneKidomet = PhoneKidumet;
                u.PhoneNum = PhoneNum;
                u.Email = Email;

                string originalName = u.UserName;
                return u;
            }
        }

        public void RemoveAdmin(string admin)
        {
            using (basicEntities be = new basicEntities())
            {
                User AdminToRemove = be.Users.Find(admin);

                be.Users.Remove(AdminToRemove);
                be.SaveChanges();
            }
        }
    }
}
