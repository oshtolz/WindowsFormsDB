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
    
    public partial class ExcursionBusDriver
    {
        public int excursionId { get; set; }
        public int busId { get; set; }
        public int driverId { get; set; }
    
        public virtual Bus Bus { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual Excursion Excursion { get; set; }
    }
}
