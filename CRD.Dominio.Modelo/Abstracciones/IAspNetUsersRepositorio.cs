using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface IAspNetUsersRepositorio: IBaseRepositorio<AspNetUsers>
    {
        AspNetUsers ObtenerUsuarioPorEmail(string email);
        AspNetUsers ObtenerUsuarioPorId(string id);
    }
}
