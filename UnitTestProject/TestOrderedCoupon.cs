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
    public class TestOrderedCoupon
    {
        User customer;
        User admin;
        User owner;
        Business bus;
        Coupon.Coupon cop;
        OrderedCoupon oc;

        [TestInitialize]
        public void TestInit()
        {
            using (basicEntities be = new basicEntities())
            {
                owner = be.Users.Find("owner");
                if (owner == null)
                {

                    owner = new Owner();
                    owner.Name = "adam";
                    owner.UserName = "owner";
                    owner.Password = "admin123123";
                    owner.PhoneKidomet = 054;
                    owner.PhoneNum = 3134195;
                    owner.Email = "adamin@gmail.com";
                }


                admin = be.Users.Find("admin");
                if (admin == null)
                {
                    admin = new Admin();
                    admin.Name = "adam";
                    admin.UserName = "admin";
                    admin.Password = "admin123123";
                    admin.PhoneKidomet = 054;
                    admin.PhoneNum = 3134195;
                    admin.Email = "adamin@gmail.com";
                }

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
                
                bus = be.Businesses.Find("123");
                if (bus == null)
                {
                    bus = new Business();
                    bus.BusinessID = "123";
                    bus.Admin = (Admin)admin;
                    bus.Owner = (Owner)owner;
                    bus.Address = "beer sheva";
                    bus.Name = "plastics maker";
                    bus.Category = Category.CarsAccessories;
                }


                cop = new Coupon.Coupon();

                cop.Id = 2;
                cop.Name = "Fly PIZZA";
                cop.OriginalPrice = "100";
                cop.DiscountPrice = "40";
                cop.Business = bus;
                cop.ExperationDate = "10/10/2014";
                cop.AvarageRanking = "0";
                cop.Description = "blabla";
            }
        }

        [TestMethod]
        public void TestAddOrderedCoupon()
        {
            using (basicEntities be = new basicEntities())
            {
                oc = new OrderedCoupon();
                oc.Id = 4;
                oc.Status = SourceType.NotUsed;
                oc.PurchaseDate = "27/04/1990";
                oc.Coupon = cop;
                oc.UseDate = "";
                oc.Rank = "0";
                oc.Opinion = "";

                oc.Customer = (Customer)customer;

                be.OrderedCoupons.Add(oc);
                             
                be.SaveChanges();

                Assert.AreEqual(be.OrderedCoupons.Find(oc.Id).PurchaseDate, oc.PurchaseDate);
               
            }
        }

        [TestCleanup]
        public void CleanUp()
        {
            using (basicEntities be = new basicEntities())
            {
                be.OrderedCoupons.Remove(be.OrderedCoupons.Find(oc.Id));
                be.Coupons.Remove(be.Coupons.Find(cop.Id));
                be.Businesses.Remove(be.Businesses.Find(bus.BusinessID));
                be.Users.Remove(be.Users.Find(admin.UserName));
                be.Users.Remove(be.Users.Find(owner.UserName));
                be.SaveChanges();
            }
        }
    }
}
