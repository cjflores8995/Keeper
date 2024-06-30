using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_TipoDocumentoPagosRepositorioImpl : BaseRepositorioImpl<CRD_TipoDocumentoPagos>, ICRD_TipoDocumentoPagosRepositorio
    {
        public CRD_TipoDocumentoPagos buscarPorNombre(string nombre)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from tipoDocumentoPago in context.CRD_TipoDocumentoPagos
                                    where tipoDocumentoPago.Nombre == nombre
                                    select tipoDocumentoPago;
                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar el tipo de documento", ex);
            }
        }
    }
}