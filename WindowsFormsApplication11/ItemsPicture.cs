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
    
    public partial class ItemsPicture
    {
        public int ImageID { get; set; }
        public byte[] imageVar { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> Combo_Item_ID { get; set; }
        public Nullable<int> Menu_Item_ID { get; set; }
    
        public virtual Combo Combo { get; set; }
        public virtual Menu_Item Menu_Item { get; set; }
    }
}
