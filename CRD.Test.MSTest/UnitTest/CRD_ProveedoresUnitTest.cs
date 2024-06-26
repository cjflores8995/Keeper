using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_ProveedoresUnitTest
    {
        CRD_ProveedoresServicio _service = new CRD_ProveedoresServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_Proveedores entry = new CRD_Proveedores();

            entry.CodigoCompania = "C001";
            entry.CodigoSistema = "Codigo 2";
            entry.CodigoServicio = "servicio";
            entry.Proceso = "proceso 3";
            entry.Resultado = "Ok";
            entry.Estado = "activo";
            entry.Error = "error";
            entry.FechaProceso = DateTime.Now.ToString();
            entry.CodTipoProveedor = "TP002";
            entry.RucCedula = "1741454125001";
            entry.RazonSocial = "proveedor 2";
            entry.CodProveedor = "P005";
            entry.Estado2 = "esado";
            entry.Ciudad = "Quito";
            entry.CodGrupoContable = "GC003";
            entry.CodPais = "EC";
            entry.Direccion1 = "direccion";

            _service.Add(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.CodigoCompania}, {item.CodigoSistema}");
        }

    }
}
