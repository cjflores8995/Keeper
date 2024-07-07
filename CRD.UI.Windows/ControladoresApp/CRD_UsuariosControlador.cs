using CRD.APP.Aplicacion.ClaseServicio;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.ControladoresApp
{
    public class CRD_UsuariosControlador
    {
        private readonly CRD_UsuariosServicio servicio;

        public CRD_UsuariosControlador()
        {
            servicio = new CRD_UsuariosServicio();
        }

        public bool LoginUsuario(string usuario, string password)
        {
            return servicio.LoginUsuario(usuario, password);
        }
    }
}
