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
    
    public partial class Stock_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stock_Order()
        {
            this.Stock_Order_Line = new HashSet<Stock_Order_Line>();
        }
    
        public int Stock_Order_ID { get; set; }
        public string Stock_Order_Description { get; set; }
        public System.DateTime Stock_Order_Issue_Date { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public Nullable<int> Stock_Order_Status_ID { get; set; }
        public Nullable<int> Supplier_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock_Order_Line> Stock_Order_Line { get; set; }
        public virtual Stock_Order_Status Stock_Order_Status { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
