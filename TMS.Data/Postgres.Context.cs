﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class postgresEntities : DbContext
    {
        public postgresEntities()
            : base("name=postgresEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<address> addresses { get; set; }
        public virtual DbSet<addresstype> addresstypes { get; set; }
        public virtual DbSet<deliveryorder> deliveryorders { get; set; }
        public virtual DbSet<doaddressdetail> doaddressdetails { get; set; }
        public virtual DbSet<dodriverdetail> dodriverdetails { get; set; }
        public virtual DbSet<driverdetail> driverdetails { get; set; }
        public virtual DbSet<invoice> invoices { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<shipmentdetail> shipmentdetails { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
