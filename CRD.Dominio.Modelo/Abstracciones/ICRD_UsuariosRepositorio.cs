using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_UsuariosRepositorio: IBaseRepositorio<CRD_Usuarios>
    {
        CRD_Usuarios ObtenerUsuarioPorEmail(string email);
        CRD_Usuarios ObtenerUsuarioPorId(int id);
    }
}
