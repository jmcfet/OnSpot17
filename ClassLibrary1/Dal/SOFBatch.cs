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
    
    public partial class SOFBatch
    {
        public int SOFBatchID { get; set; }
        public int StoreID { get; set; }
        public int CustomerID { get; set; }
        public string BatchDWM { get; set; }
        public Nullable<System.DateTime> BatchRunDate { get; set; }
        public int TransType { get; set; }
        public string CardNo { get; set; }
        public string ExpDate { get; set; }
        public decimal Amount { get; set; }
        public string Member { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string AuthNo { get; set; }
        public string AuthRef { get; set; }
        public bool Approved { get; set; }
        public bool Deleted { get; set; }
        public string CardMasked { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public string DeclineTextResponse { get; set; }
        public string DeclineErrorCode { get; set; }
    }
}
