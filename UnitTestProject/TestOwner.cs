﻿using System;
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
                User u = new Owner();

                u.Name = "adam";
                u.UserName = "adamin123";
                User sameKey = be.Users.Find(u.UserName);
                while (sameKey != null && sameKey.UserName == u.UserName)
                {
                    u.UserName += "1";
                    sameKey = be.Users.Find(u.UserName);
                }
                sameKey = be.Users.Find(u.UserName);
                u.Password = "admin123123";
                u.PhoneKidomet = 054;
                u.PhoneNum = 3134195;
                u.Email = "adamin@gmail.com";

                string originalName = u.UserName;

                be.Users.Add(u);
                be.SaveChanges();

                Assert.AreEqual(be.Users.Find(u.UserName).UserName, originalName);

            }
        }
    }
}
