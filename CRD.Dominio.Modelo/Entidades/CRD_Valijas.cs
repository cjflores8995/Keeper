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
    
    public partial class CRD_Valijas
    {
        public int IdValija { get; set; }
        public int IdBitacora { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Origen { get; set; }
        public string Remitente { get; set; }
        public string Centro { get; set; }
        public string OBSV { get; set; }
        public Nullable<bool> Activo { get; set; }
    
        public virtual CRD_Bitacora CRD_Bitacora { get; set; }
    }
}
