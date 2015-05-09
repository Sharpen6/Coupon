using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupon.Data_Layer
{
   static class InterestDB
    {
        public static List<string> GetInterest()
        {
           List<string> intersts=new List<string>();
            try
            {
                using (basicEntities be = new basicEntities())

                {
                    var Interests = from b in be.Interests                            
                                    select b;
                    foreach (var item in Interests)
                    {
                        intersts.Add(item.Description);
                    } 
                    return intersts;
                }
            }
            catch
            {
                return null;
            }

        }
        public static int getInterestKey(string description)
        {
            try
            {
                using (basicEntities be = new basicEntities())
                {
                    Interest inter= be.Interests.Find(description);
                    return inter.Id;
                }
            }
            catch
            {
                return 0;
            }
        }
        public static int getAllCoupin(int interestKey)
        {
            try
            {
                using (basicEntities be = new basicEntities())
                {
                    //     var COUPONS = from b in be.                         
                    //                      select b;
                    //       foreach (var item in Interests)
                    //     {
                    //           intersts.Add(item.Description);
                    //      } 
                    //     return intersts;
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }
   }
}
