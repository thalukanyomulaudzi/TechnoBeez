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
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Customer_Order = new HashSet<Customer_Order>();
        }
    
        public int Customer_ID { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Surname { get; set; }
        public string Customer_Email { get; set; }
        public int Customer_Contact_Number { get; set; }
        public int Suburb_ID { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Order> Customer_Order { get; set; }
    }
}
