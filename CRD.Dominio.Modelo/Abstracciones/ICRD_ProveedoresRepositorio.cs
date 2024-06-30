using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_ProveedoresRepositorio : IBaseRepositorio<CRD_Proveedores>
    {
        List<CRD_Proveedores> buscarPorRUC(string rucCedula);
        CRD_Proveedores buscarPorCodProveedor(string codProveerdor);
        List<CRD_Proveedores> buscarPorRazonSocial(string razonSocial);
    }
}