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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int User_ID { get; set; }
        public string UserName { get; set; }
        public string User_Role { get; set; }
        public string User_Password { get; set; }
        public Nullable<int> User_Role_ID { get; set; }
        public Nullable<int> Audit_ID { get; set; }
        public Nullable<int> User_Log_ID { get; set; }
    
        public virtual Audit Audit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual User_Log User_Log { get; set; }
        public virtual User_Role User_Role1 { get; set; }
    }
}