using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_AnalistasUnitTest
    {
        CRD_AnalistasServicio _service = new CRD_AnalistasServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_Analistas entry = new CRD_Analistas();

            entry.IdEstadoTipoProceso = 1;
            entry.UsuarioLN = "Usuario test 1";
            entry.Nombre = "Nombre Apellido";
            entry.Activo = true;

            _service.Add(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetById(2);

            entry.Nombre = "Nombre modificado";

            _service.Update(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"ID: {item.IdAnalista}, Usuario: {item.UsuarioLN}, Nombre: {item.Nombre}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var entry = _service.GetById(2);
            Console.WriteLine($"ID: {entry.IdAnalista}, Usuario: {entry.UsuarioLN}, Nombre: {entry.Nombre}");
        }

        [TestMethod]
        public void DeleteTest()
        {
            var entry = _service.GetById(2);
            entry.Activo = false;
            _service.Update(entry);
        }

    }
}
