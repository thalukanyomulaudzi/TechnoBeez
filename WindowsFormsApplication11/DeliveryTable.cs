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
    
    public partial class DeliveryTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeliveryTable()
        {
            this.DeliveryLines = new HashSet<DeliveryLine>();
        }
    
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public double orderTotal { get; set; }
        public string customerName { get; set; }
        public Nullable<int> customerContact { get; set; }
        public Nullable<System.DateTime> orderDatef { get; set; }
        public Nullable<double> vatAmountf { get; set; }
        public string orderNotesf { get; set; }
        public Nullable<int> totalItemsf { get; set; }
        public Nullable<double> vatTot { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryLine> DeliveryLines { get; set; }
    }
}
