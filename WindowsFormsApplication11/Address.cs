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
    
    public partial class Address
    {
        public int Address_ID { get; set; }
        public string Street_Name { get; set; }
        public Nullable<int> Address_Type_ID { get; set; }
        public Nullable<int> House_No { get; set; }
        public string Province { get; set; }
        public string City_Name { get; set; }
        public Nullable<int> Supplier_ID { get; set; }
        public Nullable<int> Suburb_ID { get; set; }
    
        public virtual Suburb Suburb { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Adress_Type Adress_Type { get; set; }
    }
}
