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
    
    public partial class CRD_TipoDocumentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRD_TipoDocumentos()
        {
            this.CRD_Bitacora = new HashSet<CRD_Bitacora>();
        }
    
        public int IdTipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRD_Bitacora> CRD_Bitacora { get; set; }
    }
}
