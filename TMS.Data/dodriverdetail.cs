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
    
    public partial class dodriverdetail
    {
        public long id { get; set; }
        public Nullable<long> doid { get; set; }
        public string driverno { get; set; }
        public Nullable<System.DateTime> actiondate { get; set; }
        public string loadstatus { get; set; }
        public Nullable<decimal> drivermoney { get; set; }
        public string specialnotes { get; set; }
        public Nullable<bool> islocked { get; set; }
        public string userlogin { get; set; }
    
        public virtual deliveryorder deliveryorder { get; set; }
        public virtual deliveryorder deliveryorder1 { get; set; }
    }
}