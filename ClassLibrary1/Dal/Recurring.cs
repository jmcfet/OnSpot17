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
    
    public partial class Recurring
    {
        public int RecurringID { get; set; }
        public int StoreID { get; set; }
        public int SortBy { get; set; }
        public int GLAccountID { get; set; }
        public int AccountTypeID { get; set; }
        public bool IsDiscount { get; set; }
        public bool IsPercentOff { get; set; }
        public decimal MinimumBalance { get; set; }
        public float PercentOff { get; set; }
        public decimal DollarsOff { get; set; }
        public int TaxAuthorityID { get; set; }
        public string Description { get; set; }
        public string PrintDescription { get; set; }
        public bool Deleted { get; set; }
        public bool SalesTaxExcluded { get; set; }
        public bool IssueBelowMinBal { get; set; }
    }
}
