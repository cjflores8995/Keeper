using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_AuditoriaBitacoraUnitTest
    {
        CRD_AuditoriaBitacoraServicio _service = new CRD_AuditoriaBitacoraServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_AuditoriaBitacora entry = new CRD_AuditoriaBitacora();

            entry.IdUsuario = "1";  
            entry.NombreTabla = "CRD_Cajas";
            entry.FechaModificacion = DateTime.Now;  
            entry.RegistroHistorico = "Cambio realizado en la descripción de la caja.";

            //_service.Add(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.NombreTabla}, {item.FechaModificacion.ToString()}, {item.RegistroHistorico}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            //var item = _service.GetById(1);
            //Console.WriteLine($"{item.NombreTabla}, {item.FechaModificacion.ToString()}, {item.RegistroHistorico}");
        }

    }
}
