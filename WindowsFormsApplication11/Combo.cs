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
    
    public partial class Combo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Combo()
        {
            this.Customer_Order_Line = new HashSet<Customer_Order_Line>();
            this.ItemsPictures = new HashSet<ItemsPicture>();
            this.Stock_Combo_Line = new HashSet<Stock_Combo_Line>();
        }
    
        public int Combo_ID { get; set; }
        public string Combo_Description { get; set; }
        public double Combo_Price { get; set; }
        public Nullable<int> Combo_Type_ID { get; set; }
        public Nullable<int> Combo_Price_ID { get; set; }
        public string Combo_Name { get; set; }
    
        public virtual Combo_Price Combo_Price1 { get; set; }
        public virtual Combo_Type Combo_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Order_Line> Customer_Order_Line { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsPicture> ItemsPictures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock_Combo_Line> Stock_Combo_Line { get; set; }
    }
}
