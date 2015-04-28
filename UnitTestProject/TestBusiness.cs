using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coupon;

namespace UnitTestProject
{

    [TestClass]
    public class TestBusiness
    {
        [TestInitialize]
        public void TestInit()
        {
            TestAdmin a = new TestAdmin();
            a.TestAddAdmin();
            TestOwner b = new TestOwner();
            b.TestAddOwner();
        }


        [TestMethod]
        public void TestAddBusiness()
        {
            using (basicEntities be = new basicEntities())
            {
                Owner owner = (Owner)be.Users.Find("owner123");
                Admin admin = (Admin)be.Users.Find("Admin123");
                Business b = AddBusinesses("123", admin, owner, "beer-Sheva", "bla", Category.CarsAccessories);
                be.Businesses.Add(b);
                be.SaveChanges();
                Assert.AreEqual(be.Businesses.Find(b.BusinessID).Name, b.Name);
            }
        }


     //   [TestMethod]
        public void TestRemoveBusiness()
        {
            using (basicEntities be = new basicEntities())
            {
                RemoveBusinesses("123");
                Assert.AreEqual(be.Businesses.Find("123"), null);
            }
        }

        public static Business AddBusinesses(string BusinessID, Admin ad, Owner owner, String address, string name, Category c)
        {
            using (basicEntities be = new basicEntities())
            {
                Business b = new Business();
                b.BusinessID = BusinessID;

                Business sameKey = be.Businesses.Find(b.BusinessID);
                while (sameKey != null && sameKey.BusinessID == b.BusinessID)
                {
                    b.BusinessID += "1";
                    sameKey = be.Businesses.Find(b.BusinessID);
                }
                b.Admin = ad;
                b.Owner = owner;
                b.Address = address;
                b.Name = name;
                b.Category = c;
                return b;

            }

        }

        public static void RemoveBusinesses(string BusinessID)
        {
            using (basicEntities be = new basicEntities())
            {
                Business BusinessesToRemove = be.Businesses.Find(BusinessID);
                be.Businesses.Remove(BusinessesToRemove);
                be.SaveChanges();

            }
        }
    }
}
