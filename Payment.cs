//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int paymentId { get; set; }
        public int excursionId { get; set; }
        public int clientId { get; set; }
        public decimal price { get; set; }
        public bool isPaid { get; set; }
        public decimal paid { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Excursion Excursion { get; set; }
    }
}
