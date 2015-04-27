using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coupon;
namespace UnitTestProject
{
   // [TestClass]
    public class TestOrderedCoupon
    {
        [TestMethod]
        public void TestAddOrderedCoupon()
        {
            using (basicEntities be = new basicEntities())
            {
                Business existing = be.Businesses.Find("123");
                if (existing != null)
                    be.Businesses.Remove(existing);

                User u = new Owner();

                u.Name = "adam";
                u.UserName = "owner";
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

                be.Users.Add(u);
                be.SaveChanges();

                User a = new Admin();

                a.Name = "adam";
                a.UserName = "admin";
                sameKey = be.Users.Find(a.UserName);
                while (sameKey != null && sameKey.UserName == a.UserName)
                {
                    a.UserName += "1";
                    sameKey = be.Users.Find(a.UserName);
                }
                sameKey = be.Users.Find(a.UserName);
                a.Password = "admin123123";
                a.PhoneKidomet = 054;
                a.PhoneNum = 3134195;
                a.Email = "adamin@gmail.com";

                be.Users.Add(a);
                be.SaveChanges();





                Business b = new Business();


                b.BusinessID = "123";
                b.Admin = (Admin)a;
                b.Owner = (Owner)u;
                b.Address = "beer sheva";
                b.Name = "plastics maker";
                b.Category = Category.CarsAccessories;


                be.Businesses.Add(b);
                be.SaveChanges();

                Coupon.Coupon cop = new Coupon.Coupon();

                cop.Id = 2;
                cop.Name = "Fly PIZZA";
                cop.OriginalPrice = "100";
                cop.DiscountPrice = "40";
                cop.Business = b;
                cop.ExperationDate = "10/10/2014";
                
                be.Coupons.Add(cop);

                be.SaveChanges();


                OrderedCoupon oc = new OrderedCoupon();
                oc.Id = 4;
                oc.Status = SourceType.NotUsed;
                oc.PurchaseDate = "27/04/1990";
                oc.Coupon = cop;
                be.OrderedCoupons.Add(oc);
                be.SaveChanges();
            }
        }
    }
}
