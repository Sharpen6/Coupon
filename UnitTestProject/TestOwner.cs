using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coupon;

namespace UnitTestProject
{
    [TestClass]
    public class TestOwner
    {
        [TestMethod]
        public void TestAddOwner()
        {
            using (basicEntities be = new basicEntities())
            {
                Owner o = AddOwner("owner123", "adam", "admin123123", 054, 3134195, "adamin@gmail.com");
                be.Users.Add(o);
                be.SaveChanges();
                Assert.AreEqual(be.Users.Find(o.UserName).UserName, o.UserName);

            }
        }

        [TestMethod]
        public void TestRemoveOwner()
        {
            using (basicEntities be = new basicEntities())
            {
                RemoveOwner("owner123");
                Assert.AreEqual(be.Users.Find("owner123"), null);
            }
        }

        public static Owner AddOwner(string UserName, String Name, String Password, int PhoneKidumet, int PhoneNum, string Email)
        {
            using (basicEntities be = new basicEntities())
            {
                Owner u = new Owner();
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

        public static void RemoveOwner(string owner)
        {
            using (basicEntities be = new basicEntities())
            {
                User userToRemove = be.Users.Find(owner);

                be.Users.Remove(userToRemove);
                be.SaveChanges();
            }
        }
    }
}
