﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminAlmacen.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AlmacenDBEntities : DbContext
    {
        public AlmacenDBEntities()
            : base("name=AlmacenDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<invoice> invoice { get; set; }
        public virtual DbSet<invoiceDetail> invoiceDetail { get; set; }
        public virtual DbSet<module> module { get; set; }
        public virtual DbSet<operation> operation { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<provider> provider { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<role_operation> role_operation { get; set; }
        public virtual DbSet<store> store { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<user_store> user_store { get; set; }
    }
}