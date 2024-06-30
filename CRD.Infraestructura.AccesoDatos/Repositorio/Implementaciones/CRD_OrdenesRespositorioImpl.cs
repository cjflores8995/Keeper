using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_OrdenesRespositorioImpl : BaseRepositorioImpl<CRD_Ordenes>, ICRD_OrdenesRepositorio
    {
        public List<CRD_Ordenes> buscarPorNumeroOrden(string numeroOrden)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from ordenes in context.CRD_Ordenes
                                    where ordenes.NumeroOrden == numeroOrden
                                    select ordenes;
                    return resultado.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la lista de ordenes", ex);
            }
        }
    }
}