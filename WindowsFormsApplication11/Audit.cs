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
    
    public partial class Audit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Audit()
        {
            this.Users = new HashSet<User>();
        }
    
        public int Audit_ID { get; set; }
        public string Audit_Name { get; set; }
        public string Audit_Table { get; set; }
        public string Audit_Description { get; set; }
        public int User_ID { get; set; }
        public Nullable<int> transactionNumber { get; set; }
        public Nullable<System.DateTime> auditDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
