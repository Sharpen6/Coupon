using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coupon;

namespace UnitTestProject
{
    [TestClass]
    public class TestBusiness
    {
        User owner;
        User admin;
        [TestInitialize]
        public void Init()
        {
            using (basicEntities be = new basicEntities())
            {
                owner = new Owner();

                owner.Name = "ownerName";
                owner.UserName = "owner";
                User sameKey = be.Users.Find(owner.UserName);
                while (sameKey != null)
                {
                    owner.UserName += "1";
                    sameKey = be.Users.Find(owner.UserName);
                }
                owner.Password = "admin123123";
                owner.PhoneKidomet = 054;
                owner.PhoneNum = 3134195;
                owner.Email = "adamin@gmail.com";

                admin = new Admin();

                admin.Name = "adminName";
                admin.UserName = "admin";
                sameKey = be.Users.Find(admin.UserName);
                while (sameKey != null)
                {
                    admin.UserName += "1";
                    sameKey = be.Users.Find(admin.UserName);
                }
                admin.Password = "admin123123";
                admin.PhoneKidomet = 054;
                admin.PhoneNum = 3134195;
                admin.Email = "adamin@gmail.com";


            }
        }
        [TestMethod]
        public void TestAddBusiness()
        {
            

            using (basicEntities be = new basicEntities())
            {

                Business existing = be.Businesses.Find("123");
                if (existing != null)
                {
                    be.Businesses.Remove(existing);
                    be.SaveChanges();
                }

                
                be.Users.Add(owner);
                be.Users.Add(admin);
                //be.SaveChanges();

                Business b = new Business();
                
                b.BusinessID = "123";
                b.Admin = (Admin)admin;
                b.Owner = (Owner)owner;
                b.Address = "beer sheva";
                b.Name = "plastics maker";
                b.Category = Category.CarsAccessories;

                
                be.Businesses.Add(b);
                be.SaveChanges();

                Assert.AreEqual(be.Businesses.Find(b.BusinessID).Name, b.Name);
            }
        }
    }
}
