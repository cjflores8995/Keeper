//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRD.Dominio.Modelo.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class CRD_Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRD_Usuarios()
        {
            this.CRD_AuditoriaBitacora = new HashSet<CRD_AuditoriaBitacora>();
            this.CRD_Bitacora = new HashSet<CRD_Bitacora>();
            this.CRD_UsuarioRoles = new HashSet<CRD_UsuarioRoles>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public System.DateTime FechaUltimoAcceso { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Telefono { get; set; }
        public string NombreUsuario { get; set; }
        public bool Activo { get; set; }

        public int IdCargo { get; set; }
        public int IdDepartamento { get; set; }
        public int IdCiudad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRD_AuditoriaBitacora> CRD_AuditoriaBitacora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRD_Bitacora> CRD_Bitacora { get; set; }
        public virtual CRD_Cargo CRD_Cargo { get; set; }
        public virtual CRD_Ciudad CRD_Ciudad { get; set; }
        public virtual CRD_Departamento CRD_Departamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRD_UsuarioRoles> CRD_UsuarioRoles { get; set; }
    }
}
