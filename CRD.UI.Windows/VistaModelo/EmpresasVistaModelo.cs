﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.VistaModelo
{
    public class EmpresasVistaModelo
    {
        public int IdEmpresa { get; set; }
        public string CodigoEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Activo { get; set; }
    }
}
