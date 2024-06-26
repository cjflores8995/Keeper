using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_BitacoraUnitTest
    {
        CRD_BitacoraServicio _service = new CRD_BitacoraServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_Bitacora entry = new CRD_Bitacora();

            entry.IdTipoDocumento = 2;
            entry.IdEstadoTipoProceso = 3;
            entry.IdUsuario = "user1";
            entry.IdTipoDocumentoPago = 1;
            entry.IdOrden = "1";
            entry.CodProveedor = "P001";
            entry.CodigoEmpresa = "EMP001";
            entry.IdPaquete = 1;
            entry.NumeroDocumentoPago = "DOC456";
            entry.EstadoBienesRecibidos = true;
            entry.FechaEmisionDocumento = new DateTime(2024, 6, 25);
            entry.FechaRecepcionDocumento = new DateTime(2024, 6, 26, 14, 30, 0);
            entry.IvaDocumento = 19.5m;
            entry.IdAnalista = 6;
            entry.Observaciones = "Observaciones de ejemplo";
            entry.ValorTotal = 1500.75m;
            entry.TipoOrden = "TIPO1";

            _service.Add(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetById(24);

            entry.IdUsuario = "user2";

            _service.Update(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.IdOrden}, {item.CodProveedor}, {item.CodigoEmpresa}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(24);
            Console.WriteLine($"{item.IdOrden}, {item.CodProveedor}, {item.CodigoEmpresa}");
        }

    }
}
