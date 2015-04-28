using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coupon;

namespace UnitTestProject
{

    [TestClass]
    public class TestRecommendation
    {
        User customer;
        Recommendation rec;

        [TestInitialize]
        public void TestInit()
        {
            using (basicEntities be = new basicEntities())
            {
                customer = be.Users.Find("customer");
                if (customer == null)
                {
                    customer = new Customer();
                    customer.Name = "adam";
                    customer.UserName = "customer";
                    customer.Password = "admin123123";
                    customer.PhoneKidomet = 054;
                    customer.PhoneNum = 3134195;
                    customer.Email = "adamin@gmail.com";
                }
            }
        }

        [TestMethod]
        public void TestAddRecommendation()
        {
            using (basicEntities be = new basicEntities())
            {
                rec = new Recommendation();
                rec.Description = "blabla";
                rec.Id = 4;
                rec.Link = "www.google.com";
                rec.Source = SourceType.GooglePlus;

                rec.Customer = (Customer)customer;
                be.Users.Add(customer);
                be.Recommendations.Add(rec);
                be.SaveChanges();

                Assert.AreEqual(be.Recommendations.Find(rec.Id).Link, rec.Link);
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            using (basicEntities be = new basicEntities())
            {
                be.Recommendations.Remove(be.Recommendations.Find(rec.Id));
                be.Users.Remove(be.Users.Find(customer.UserName));
                be.SaveChanges();
            }
        }
    }
}
