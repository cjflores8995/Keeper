using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_TipoDocumentosRepositorioImpl : BaseRepositorioImpl<CRD_TipoDocumentos>, ICRD_TipoDocumentosRepositorio
    {
        public CRD_TipoDocumentos buscarPorNombre(string nombre)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from tipoDocumento in context.CRD_TipoDocumentos
                                    where tipoDocumento.Nombre == nombre
                                    select tipoDocumento;
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