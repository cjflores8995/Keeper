using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_ProveedoresRepositorioImpl : BaseRepositorioImpl<CRD_Proveedores>, ICRD_ProveedoresRepositorio
    {
        public CRD_Proveedores buscarPorCodProveedor(string codProveerdor)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from proveedor in context.CRD_Proveedores
                                    where proveedor.CodProveedor == codProveerdor
                                    select proveedor;
                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar registro", ex);
            }
        }

        public List<CRD_Proveedores> buscarPorRazonSocial(string razonSocial)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from proveedor in context.CRD_Proveedores
                                    where proveedor.RazonSocial == razonSocial
                                    select proveedor;
                    return resultado.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la lista", ex);
            }
        }

        public List<CRD_Proveedores> buscarPorRUC(string rucCedula)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from proveedor in context.CRD_Proveedores
                                    where proveedor.RucCedula == rucCedula
                                    select proveedor;
                    return resultado.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la lista", ex);
            }
        }
    }
}