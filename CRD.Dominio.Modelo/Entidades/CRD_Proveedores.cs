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
    
    public partial class CRD_Proveedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRD_Proveedores()
        {
            this.CRD_Bitacora = new HashSet<CRD_Bitacora>();
        }
    
        public string CodigoCompania { get; set; }
        public string CodigoSistema { get; set; }
        public string CodigoServicio { get; set; }
        public string Proceso { get; set; }
        public string Resultado { get; set; }
        public string Estado { get; set; }
        public string Error { get; set; }
        public string FechaProceso { get; set; }
        public string CodTipoProveedor { get; set; }
        public string RucCedula { get; set; }
        public string RazonSocial { get; set; }
        public string CodProveedor { get; set; }
        public string Estado2 { get; set; }
        public string Ciudad { get; set; }
        public string CodGrupoContable { get; set; }
        public string CodPais { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Ciudad2 { get; set; }
        public string ContactoVentas { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Fax { get; set; }
        public Nullable<double> ContribuyenteEspecial { get; set; }
        public string CodCondicionesPago { get; set; }
        public string CodClasificacionProv { get; set; }
        public string Divisas { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public string ApartadoCorreo { get; set; }
        public string Telefono { get; set; }
        public string EstadoPro { get; set; }
        public string Email { get; set; }
        public string ProveedorExterior { get; set; }
        public string EstadoEstandar { get; set; }
        public string FechaCreacion { get; set; }
        public string TipoDocumento { get; set; }
        public string Sector { get; set; }
        public string Proponente { get; set; }
        public string VigenciaCertificado { get; set; }
        public string nombreArchivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRD_Bitacora> CRD_Bitacora { get; set; }
    }
}
