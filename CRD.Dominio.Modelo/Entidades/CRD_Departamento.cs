
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

    public partial class CRD_Departamento
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRD_Departamento()
        {

            this.CRD_Usuarios = new HashSet<CRD_Usuarios>();

        }


        public int IdDepartamento { get; set; }

        public string NombreDepartamento { get; set; }

        public string Descripcion { get; set; }

        public bool Activo { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<CRD_Usuarios> CRD_Usuarios { get; set; }

    }

}
