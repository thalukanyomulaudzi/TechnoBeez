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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Customer_Order = new HashSet<Customer_Order>();
            this.Employee_Booking_Shift = new HashSet<Employee_Booking_Shift>();
        }
    
        public int Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Surname { get; set; }
        public string Employee_Identity_Number { get; set; }
        public string Email_Adress { get; set; }
        public string Contact_Number { get; set; }
        public string Next_Of_Kin_Name { get; set; }
        public string Next_Of_Kin_Contact_Number { get; set; }
        public string Adress { get; set; }
        public Nullable<int> Gender_ID { get; set; }
        public Nullable<int> User_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Order> Customer_Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Booking_Shift> Employee_Booking_Shift { get; set; }
        public virtual Employee_Gender_ Employee_Gender_ { get; set; }
        public virtual User User { get; set; }
    }
}
