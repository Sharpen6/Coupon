using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coupon;

namespace UnitTestProject
{
    /// <summary>
    /// Summary description for TestVisits
    /// </summary>
    [TestClass]
    public class TestLocation
    {
        Location loc;

        [TestInitialize]
        public void TestInit()
        {

        }

        [TestMethod]
        public void TestAddVisit()
        {
            using (basicEntities be = new basicEntities())
            {
                loc = new Location();

                loc.Id = 4;
                loc.Coordinates = "34N 40' 50.12";
                
                be.Locations.Add(loc);
               
                be.SaveChanges();

                Assert.AreEqual(be.Locations.Find(loc.Id).Coordinates, loc.Coordinates);
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            using (basicEntities be = new basicEntities())
            {
                be.Locations.Remove(be.Locations.Find(loc.Id));
                be.SaveChanges();
            }
        }
    }
}
