//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webapisatheeshkumartest.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table
    {
        public System.Guid Id { get; set; }
        public long ApplicationId { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime PostingDate { get; set; }
        public bool IsCleared { get; set; }
        public Nullable<System.DateTime> ClearedDate { get; set; }
    }
}
