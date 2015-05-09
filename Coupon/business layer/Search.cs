using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coupon.Data_Layer;

namespace Coupon.business_layer
{
    static class Search
    {
        public static List<string> getCategory()
        {
            List<string> interst = new List<string>();
            //List<string> interst= InterestDB.GetInterest();
            interst.Add("ALL");
            interst.AddRange(InterestDB.GetInterest());
            return interst;
        }

        public static void SearchLocation(Location loc)
        {

        }
        public static void SearchInterest(string inter)
        {
            int interestKey = InterestDB.getInterestKey(inter);

        }
    }
}
