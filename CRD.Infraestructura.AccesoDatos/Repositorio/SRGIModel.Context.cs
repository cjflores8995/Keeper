﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRD.Infraestructura.AccesoDatos.Repositorio
{
    using CRD.Dominio.Modelo.Entidades;

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SRGI_4Entities : DbContext
    {
        public SRGI_4Entities()
            : base("name=SRGI_4Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<CRD_Analistas> CRD_Analistas { get; set; }
        public virtual DbSet<CRD_AuditoriaBitacora> CRD_AuditoriaBitacora { get; set; }
        public virtual DbSet<CRD_Bitacora> CRD_Bitacora { get; set; }
        public virtual DbSet<CRD_Cajas> CRD_Cajas { get; set; }
        public virtual DbSet<CRD_Cargo> CRD_Cargo { get; set; }
        public virtual DbSet<CRD_Ciudad> CRD_Ciudad { get; set; }
        public virtual DbSet<CRD_Departamento> CRD_Departamento { get; set; }
        public virtual DbSet<CRD_Empresas> CRD_Empresas { get; set; }
        public virtual DbSet<CRD_EstadoTipoProcesos> CRD_EstadoTipoProcesos { get; set; }
        public virtual DbSet<CRD_Iva> CRD_Iva { get; set; }
        public virtual DbSet<CRD_Ordenes> CRD_Ordenes { get; set; }
        public virtual DbSet<CRD_Paquetes> CRD_Paquetes { get; set; }
        public virtual DbSet<CRD_Proveedores> CRD_Proveedores { get; set; }
        public virtual DbSet<CRD_TipoDocumentoPagos> CRD_TipoDocumentoPagos { get; set; }
        public virtual DbSet<CRD_TipoDocumentos> CRD_TipoDocumentos { get; set; }
        public virtual DbSet<CRD_Valijas> CRD_Valijas { get; set; }
        public virtual DbSet<CRD_BitacoraHistorico> CRD_BitacoraHistorico { get; set; }
    }
}
