﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coupon;

namespace UnitTestProject
{
    [TestClass]
    public class TestCustomer
    {    [TestMethod]
        public void TestAddCustomer()
        {
            using (basicEntities be = new basicEntities())
            {
                Customer c = AddCustomer("Customer123", "adam", "admin123123", 054, 3134195, "adamin@gmail.com");
                be.Users.Add(c);
                be.SaveChanges();
                Assert.AreEqual(be.Users.Find(c.UserName).UserName, c.UserName);

            }
        }
      
        [TestMethod]
        public void TestRemoveCustomer()
        {
            using (basicEntities be = new basicEntities())
            {
                RemoveCustomer("Customer123");
                Assert.AreEqual(be.Users.Find("Customer123"), null);
            }
        }

        public Customer AddCustomer(string UserName, String Name, String Password, int PhoneKidumet, int PhoneNum, string Email)
        {
            using (basicEntities be = new basicEntities())
            {
                Customer u = new Customer();
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

        public void RemoveCustomer(string Customer)
        {
            using (basicEntities be = new basicEntities())
            {
                User userToRemove = be.Users.Find(Customer);
                
                be.Users.Remove(userToRemove);
                be.SaveChanges();
            }
        }
    
        
    }
}
