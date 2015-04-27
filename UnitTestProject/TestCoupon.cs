using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coupon;
namespace UnitTestProject
{
   [TestClass]
    public class TestCoupon
    {
        TestOwner t=new TestOwner();
        TestAdmin t1=new TestAdmin();
        TestBusiness t2=new TestBusiness();
        [TestMethod]
        public void TestAddCoupon()
        {
            using (basicEntities be = new basicEntities())
            {
                Owner u = t.AddOwner("CouponOwnerr", "adam", "admin123123", 054, 3134195, "adamin@gmail.com");
                be.Users.Add(u);   
                Admin a = t1.AddAdmin("CouponAdmin", "adam", "admin123123", 054, 3134195, "adamin@gmail.com");    
                be.Users.Add(a);
                Business b = t2.AddBusinesses("123", a, u, "beer-sheva", "d", Category.CarsAccessories);
                be.Businesses.Add(b);
                Coupon.Coupon cop = CreateCoupon(2, "Fly PIZZA", "100", "40", b, "10/10/2014");       
                be.Coupons.Add(cop);
                be.SaveChanges();

            }
        }

        public   Coupon.Coupon CreateCoupon(int id, string name, string orgprice, string discount, Business b, string datee)
        {
            Coupon.Coupon cop = new Coupon.Coupon();
            cop.Id = id;
            cop.Name = name;
            cop.OriginalPrice = orgprice;
            cop.DiscountPrice = discount;
            cop.Business = b;
            cop.ExperationDate = datee;

            return cop;
        }

        public void RemoveCoupon(string CouponID)
        {
            using (basicEntities be = new basicEntities())
            {
                Coupon.Coupon CouponToRemove = be.Coupons.Find(CouponID);
                be.Coupons.Remove(CouponToRemove);
              //  t2.RemoveBusinesses(CouponToRemove.Business.BusinessID);
                RemoveCoupon("2");
                be.SaveChanges();
            }
        }

        [TestMethod]
        public void TestRemoveCoupon()
        {
            using (basicEntities be = new basicEntities())
            {
       
                Assert.AreEqual(be.Businesses.Find("2"), null);


            }
        }
   }
}
