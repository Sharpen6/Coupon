using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coupon;

namespace UnitTestProject
{
    [TestClass]
    public class TestUser
    {
        [TestMethod]
        public void TestAddUser()
        {
            using (basicEntities be = new basicEntities())
            {
                User u = AddUser("User123", "adam", "admin123123", 054, 3134195, "adamin@gmail.com");
                be.Users.Add(u);
                be.SaveChanges();
                Assert.AreEqual(be.Users.Find(u.UserName).UserName, u.UserName);
            }
        }

        [TestMethod]
        public void TestUpdatePhoneUser()
        {
            using (basicEntities be = new basicEntities())
            {

                User user = be.Users.Find("User123");
                user.PhoneNum = 2222222;
                be.SaveChanges();

                Assert.AreEqual(be.Users.Find("User123").PhoneNum, 2222222);
            }
        }

        [TestMethod]
        public void TestUpdatePhoneKidumet()
        {
            using (basicEntities be = new basicEntities())
            {

                User user = be.Users.Find("User123");
                user.PhoneKidomet = 052;
                be.SaveChanges();

                Assert.AreEqual(be.Users.Find("User123").PhoneKidomet, 052);
            }
        }

        [TestMethod]
        public void TestRemoveUser()
        {
            using (basicEntities be = new basicEntities())
            {
                RemoveUser("User123");
                Assert.AreEqual(be.Users.Find("User123"), null);
            }
        }

        public void RemoveUser(string user)
        {
            using (basicEntities be = new basicEntities())
            {
                User userToRemove = be.Users.Find(user);
                be.Users.Remove(userToRemove);
                be.SaveChanges();
            }
        }

        public User AddUser(string UserName, String Name, String Password, int PhoneKidumet, int PhoneNum, string Email)
        {
            using (basicEntities be = new basicEntities())
            {
                User u = new User();
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

                return u;
            }
        }
    }
}
