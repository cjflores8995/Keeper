
//------------------------------------------------------------------------------
// <auto-generated>
//     Este c�digo se gener� a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicaci�n.
//     Los cambios manuales en este archivo se sobrescribir�n si se regenera el c�digo.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CRD.Dominio.Modelo.Entidades
{

    using System;
    using System.Collections.Generic;

    public partial class CRD_Empresas
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRD_Empresas()
        {

            this.CRD_Bitacora = new HashSet<CRD_Bitacora>();

        }


        public int IdEmpresa { get; set; }

        public string CodigoEmpresa { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public bool Activo { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<CRD_Bitacora> CRD_Bitacora { get; set; }

    }

}
