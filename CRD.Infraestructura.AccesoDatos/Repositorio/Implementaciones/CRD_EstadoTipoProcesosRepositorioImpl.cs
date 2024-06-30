using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_EstadoTipoProcesosRepositorioImpl : BaseRepositorioImpl<CRD_EstadoTipoProcesos>, ICRD_EstadoTipoProcesosRepositorio
    {
        public CRD_EstadoTipoProcesos buscarPorNombre(string nom)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from pasc in context.CRD_EstadoTipoProcesos
                                    where pasc.Nombre == nom
                                    select pasc;
                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error ", ex);
            }
        }
    }
}