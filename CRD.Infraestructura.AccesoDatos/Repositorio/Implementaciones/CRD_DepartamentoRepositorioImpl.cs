using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_DepartamentoRepositorioImpl : BaseRepositorioImpl<CRD_Departamento>, ICRD_DepartamentoRepositorio
    {
        public CRD_Departamento buscarPorNombreDepartamento(string nomdep)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from pasc in context.CRD_Departamento
                                    where pasc.NombreDepartamento == nomdep
                                    select pasc;
                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar registro,", ex);
            }
        }
    }
}