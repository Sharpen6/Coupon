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
    
    public partial class OrderedCoupon
    {
        public int SerialNum { get; set; }
        public StatusType Status { get; set; }
        public string PurchaseDate { get; set; }
        public string UseDate { get; set; }
        public string Opinion { get; set; }
        public string Rank { get; set; }
    
        public virtual Coupon Coupon { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
