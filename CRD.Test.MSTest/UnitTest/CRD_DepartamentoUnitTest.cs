using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_DepartamentoUnitTest
    {
        CRD_DepartamentoServicio _service = new CRD_DepartamentoServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_Departamento entry = new CRD_Departamento();

            entry.NombreDepartamento = "nombre depar";
            entry.Descripcion = "descripcion";
            entry.Activo = true;

            _service.Add(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetById(6);

            entry.NombreDepartamento = "Nombre modificado";

            _service.Update(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.NombreDepartamento}, {item.Descripcion}, {item.Activo}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(6);
            Console.WriteLine($"{item.NombreDepartamento}, {item.Descripcion}, {item.Activo}");
        }

        [TestMethod]
        public void DeleteTest()
        {
            var entry = _service.GetById(6);
            entry.Activo = false;
            _service.Update(entry);
        }

    }
}
