//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class CardBillAutoCredit
    {
        public int AutoCreditID { get; set; }
        public int StoreID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public string Description { get; set; }
        public decimal OrigBalance { get; set; }
        public decimal Balance { get; set; }
    }
}
