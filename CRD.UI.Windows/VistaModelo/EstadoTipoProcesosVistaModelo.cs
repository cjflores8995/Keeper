﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.VistaModelo
{
    public class EstadoTipoProcesosVistaModelo
    {
        public int IdEstadoTipoProceso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Activo { get; set; }
    }
}
