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

        [TestInitialize]
        public void TestInit()
        {
            TestBusiness b = new TestBusiness();
            b.TestInit();
            b.TestAddBusiness();
        }
        [TestMethod]
        public void TestAddCoupon()
        {
            using (basicEntities be = new basicEntities())
            {

                Business b = be.Businesses.Find("123");
                Coupon.Coupon cop = CreateCoupon(2, "Fly PIZZA", "100", "40", b, "10/10/2014");
                be.Coupons.Add(cop);
                be.SaveChanges();


            }
        }

        public static Coupon.Coupon CreateCoupon(int id, string name, string orgprice, string discount, Business b, string datee)
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

        public static void RemoveCoupon(int CouponID)
        {
            using (basicEntities be = new basicEntities())
            {
                Coupon.Coupon CouponToRemove = be.Coupons.Find(CouponID);
                be.Coupons.Remove(CouponToRemove);
                be.SaveChanges();
            }
        }

        [TestMethod]
        public void TestRemoveCoupon()
        {
            int CouponID = 0;
            using (basicEntities be = new basicEntities())
            {
                var query = from b in be.Coupons
                            select b;
                if (query.Count() > 0)
                {
                    Coupon.Coupon CouponToRemove = be.Coupons.Find(CouponID);
                    while (CouponToRemove == null)
                    {
                        CouponID = CouponID + 1;
                        CouponToRemove = be.Coupons.Find(CouponID);
                    }
                    RemoveCoupon(CouponID);
                }
            }
                using (basicEntities be = new basicEntities())
                {
                    Assert.AreEqual(be.Coupons.Find(CouponID), null);


                
            }
        }
    }
}
