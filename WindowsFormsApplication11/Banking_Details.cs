//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication11
{
    using System;
    using System.Collections.Generic;
    
    public partial class Banking_Details
    {
        public int Banking_Details_ID { get; set; }
        public string Bank_Name { get; set; }
        public int Bank_Acc_No { get; set; }
        public int Branch_Code { get; set; }
        public Nullable<int> Supplier_ID { get; set; }
    
        public virtual Supplier Supplier { get; set; }
    }
}
