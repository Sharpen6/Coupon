//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coupon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        public Location()
        {
            this.Businesses = new HashSet<Business>();
        }
    
        public int Id { get; set; }
        public string Coordinates { get; set; }
    
        public virtual ICollection<Business> Businesses { get; set; }
    }
}
