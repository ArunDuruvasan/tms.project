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
    
    public partial class useractivity
    {
        public System.Guid activitykey { get; set; }
        public Nullable<System.Guid> userkey { get; set; }
        public Nullable<System.DateTime> activitytimestamp { get; set; }
        public string refno { get; set; }
        public string comments { get; set; }
    
        public virtual userinfo userinfo { get; set; }
    }
}