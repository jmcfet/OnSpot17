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
    
    public partial class Reason
    {
        public int ReasonID { get; set; }
        public string Description { get; set; }
        public Nullable<int> ReasonType { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public bool Deleted { get; set; }
    }
}
