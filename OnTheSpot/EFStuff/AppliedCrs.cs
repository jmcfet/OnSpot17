//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnTheSpot.EFStuff
{
    using System;
    using System.Collections.Generic;
    
    public partial class AppliedCrs
    {
        public int AppliedCrID { get; set; }
        public int StoreID { get; set; }
        public int CreditID { get; set; }
        public int PaymentID { get; set; }
        public int AppliedEmpID { get; set; }
        public Nullable<System.DateTime> AppliedDate { get; set; }
        public decimal PaidAmount { get; set; }
        public bool Deleted { get; set; }
        public int AccountType { get; set; }
    }
}
