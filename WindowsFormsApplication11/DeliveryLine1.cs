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
    
    public partial class DeliveryLine1
    {
        public int LineId { get; set; }
        public Nullable<int> comboItemId { get; set; }
        public Nullable<int> stockItemId { get; set; }
        public Nullable<int> menuItemId { get; set; }
        public Nullable<int> comboItemQuantity { get; set; }
        public Nullable<int> stockItemQuantity { get; set; }
        public Nullable<int> menuItemQuantity { get; set; }
        public Nullable<int> orderId { get; set; }
    
        public virtual DeliveryTable1 DeliveryTable { get; set; }
    }
}
