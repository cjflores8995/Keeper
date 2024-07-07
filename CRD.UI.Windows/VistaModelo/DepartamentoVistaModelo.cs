using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.VistaModelo
{
    public class DepartamentoVistaModelo
    {
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Activo { get; set; }
    }
}
