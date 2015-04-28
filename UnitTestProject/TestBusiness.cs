using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coupon;

namespace UnitTestProject
{
   [TestClass]
    public class TestBusiness
    {
        TestOwner to = new TestOwner();
        TestAdmin ad = new TestAdmin();

        [TestMethod]
        public void TestAddBusiness()
        {
            using (basicEntities be = new basicEntities())
            {
                Owner owner = to.AddOwner("ownerBus", "ownerName", "admin123123", 054, 3134195, "adamin@gmail.com");
                Admin admin = ad.AddAdmin("AdminBus", "ownerName", "admin123123", 054, 3134195, "adamin@gmail.com");
                be.Users.Add(owner);
                be.Users.Add(admin);
                Business b = AddBusinesses("123", admin, owner, "beer-Sheva", "bla", Category.CarsAccessories);
                be.Businesses.Add(b);
                be.SaveChanges();
                Assert.AreEqual(be.Businesses.Find(b.BusinessID).Name, b.Name);
            }
        }


        [TestMethod]
        public void TestRemoveBusiness()
        {
            using (basicEntities be = new basicEntities())
            {
                Owner owner = to.AddOwner("ownerBus", "ownerName", "admin123123", 054, 3134195, "adamin@gmail.com");
                Admin admin = ad.AddAdmin("AdminBus", "ownerName", "admin123123", 054, 3134195, "adamin@gmail.com");
                be.Users.Add(owner);
                be.Users.Add(admin);
                Business b = AddBusinesses("123", admin, owner, "beer-Sheva", "bla", Category.CarsAccessories);
                be.Businesses.Add(b);
                be.SaveChanges();


                Business BusinessesToRemove = be.Businesses.Find("123");
                be.Businesses.Remove(BusinessesToRemove);
                be.SaveChanges();

                Assert.AreEqual(be.Businesses.Find("123"), null);
            }
        }
         
         public Business AddBusinesses(string BusinessID, Admin ad, Owner owner,String address, string name, Category c)
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

        public void RemoveBusinesses(string BusinessID)
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
