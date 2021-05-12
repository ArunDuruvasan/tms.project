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
    
    public partial class tms_orderdetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tms_orderdetail()
        {
            this.tms_routes = new HashSet<tms_routes>();
            this.documents = new HashSet<document>();
            this.invoiceheaders = new HashSet<invoiceheader>();
        }
    
        public System.Guid orderdetailkey { get; set; }
        public System.Guid orderkey { get; set; }
        public string containerno { get; set; }
        public short containersize { get; set; }
        public string chassis { get; set; }
        public string sealno { get; set; }
        public Nullable<decimal> weight { get; set; }
        public Nullable<System.DateTime> apptdatefrom { get; set; }
        public Nullable<System.DateTime> apptdateto { get; set; }
        public Nullable<short> status { get; set; }
        public Nullable<System.DateTime> statusdate { get; set; }
        public Nullable<short> holdreason { get; set; }
        public Nullable<System.DateTime> holddate { get; set; }
    
        public virtual tms_containersize tms_containersize { get; set; }
        public virtual tms_holdreason tms_holdreason { get; set; }
        public virtual tms_orderheader tms_orderheader { get; set; }
        public virtual tms_orderdetailcomments tms_orderdetailcomments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tms_routes> tms_routes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<document> documents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invoiceheader> invoiceheaders { get; set; }
    }
}