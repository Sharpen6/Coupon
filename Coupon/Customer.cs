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
    
    public partial class Customer : User
    {
        public Customer()
        {
            this.OrderedCoupons = new HashSet<OrderedCoupon>();
            this.Visits = new HashSet<Visit>();
            this.Recommendations = new HashSet<Recommendation>();
            this.Customers = new HashSet<Customer>();
            this.Customers1 = new HashSet<Customer>();
        }
    
    
        public virtual ICollection<OrderedCoupon> OrderedCoupons { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual ICollection<Recommendation> Recommendations { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Customer> Customers1 { get; set; }
    }
}
