//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EfApp.WithUIConsole
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentPrice
    {
        public int StudentPriceId { get; set; }
        public int StudentId { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
