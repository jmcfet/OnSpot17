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
    
    public partial class Invoice
    {
        public int InvoiceID { get; set; }
        public int OrderID { get; set; }
        public int StoreID { get; set; }
        public int CustomerID { get; set; }
        public int DepartmentID { get; set; }
        public string Department { get; set; }
        public string Rack { get; set; }
        public string LotInfo { get; set; }
        public int InvoiceEmpID { get; set; }
        public int RackEmpID { get; set; }
        public int PickupEmpID { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> RackDate { get; set; }
        public Nullable<System.DateTime> PickupDate { get; set; }
        public bool IsMissingAmount { get; set; }
        public int WorkPhase { get; set; }
        public float Pieces { get; set; }
        public int Tax1ID { get; set; }
        public decimal Taxable { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal PaidAmount { get; set; }
        public int PaymentID { get; set; }
        public decimal CoupTotal { get; set; }
        public decimal DiscTotal { get; set; }
        public bool Deleted { get; set; }
        public decimal CoupDiscable { get; set; }
        public decimal SrvFeeable { get; set; }
        public decimal SrvFeeTotal { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string HotelRoom { get; set; }
        public string GuestName { get; set; }
        public int ValetTicketID { get; set; }
        public int BillCustomerID { get; set; }
        public int Tax2ID { get; set; }
        public int Tax3ID { get; set; }
        public decimal Taxable1 { get; set; }
        public decimal Taxable2 { get; set; }
        public decimal Taxable3 { get; set; }
        public decimal TaxTotal1 { get; set; }
        public decimal TaxTotal2 { get; set; }
        public decimal TaxTotal3 { get; set; }
        public decimal OriginalTotal { get; set; }
        public bool IsRedo { get; set; }
        public bool IsSplit { get; set; }
        public int TaxAuthorityID { get; set; }
        public string BaggerMemo { get; set; }
        public int PayCode { get; set; }
        public Nullable<System.DateTime> AssemblyDate { get; set; }
        public Nullable<System.DateTime> MarkInDate { get; set; }
        public int MarkInEmpID { get; set; }
    }
}
