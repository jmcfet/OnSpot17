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
    
    public partial class RouteItem
    {
        public int RouteID { get; set; }
        public int DriverEmpID { get; set; }
        public string Description { get; set; }
        public string PrintCode { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public bool Deleted { get; set; }
        public string RouteAgent { get; set; }
        public int InvoiceImageID { get; set; }
        public int StatementImageID { get; set; }
        public int PriceLevel { get; set; }
        public int InvoicePrinterID { get; set; }
        public string RouteExportPath { get; set; }
    }
}
