using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class AspNetUsersUnitTest
    {
        AspNetUsersServicio _service = new AspNetUsersServicio();

        [TestMethod]
        public void ObtenerUsuarioPorEmailTest()
        {
            var result = _service.ObtenerUsuarioPorEmail("john.doe@example.com");

            Console.WriteLine($"{result.FirstName}, {result.LastName}");

        }

        [TestMethod]
        public void GetByIdTest()
        {
            var result = _service.ObtenerUsuarioPorId("user1");
            Console.WriteLine($"{result.FirstName}, {result.LastName}");
        }

    }
}
