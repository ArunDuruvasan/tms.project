//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public document()
        {
            this.comments = new HashSet<comment>();
            this.tms_orderdetail = new HashSet<tms_orderdetail>();
            this.tms_orderheader = new HashSet<tms_orderheader>();
        }
    
        public System.Guid documentkey { get; set; }
        public Nullable<short> documenttype { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.Guid> createuserkey { get; set; }
        public string originalfilename { get; set; }
        public string originalfiletype { get; set; }
        public Nullable<int> filesizeinmb { get; set; }
    
        public virtual documenttype documenttype1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tms_orderdetail> tms_orderdetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tms_orderheader> tms_orderheader { get; set; }
    }
}