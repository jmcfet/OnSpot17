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
    
    public partial class NoSale
    {
        public Nullable<int> NoSaleID { get; set; }
        public Nullable<int> StoreID { get; set; }
        public Nullable<int> NoSaleTypeID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> ClerkDrawerID { get; set; }
        public Nullable<System.DateTime> NoSaleDate { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> DrawerNumber { get; set; }
        public bool Deleted { get; set; }
        public int CustomerID { get; set; }
        public int AccountType { get; set; }
        public string CardMasked { get; set; }
        public string AuthNo { get; set; }
    }
}