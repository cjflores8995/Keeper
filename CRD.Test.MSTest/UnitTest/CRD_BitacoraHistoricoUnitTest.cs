using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_BitacoraHistoricoUnitTest
    {
        CRD_BitacoraHistoricoServicio _service = new CRD_BitacoraHistoricoServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_BitacoraHistorico entry = new CRD_BitacoraHistorico();

            entry.ID = 1;
            entry.Bienes_Recibidos = "Bienes Ejemplo";
            entry.Ciudad = "Ciudad Ejemplo";
            entry.Origen_Documento = "Documento Ejemplo";
            entry.Empresa = "Empresa Ejemplo";
            entry.Estado = "Estado Ejemplo";
            entry.Factura = "Factura Ejemplo";
            entry.Fecha_Emision = "2024-06-25";
            entry.Fecha_Recepcion_CRD = "2024-06-26";
            entry.Iva = "19%";
            entry.Largo_F = "100cm";
            entry.Largo_O = "90cm";
            entry.Responsable = "Responsable Ejemplo";
            entry.Motivo_Rechazo = "Ninguno";
            entry.Nom_Proveedor = "Proveedor Ejemplo";
            entry.Numero_Orden = "123456";
            entry.Observaciones = "Observaciones Ejemplo";
            entry.Operador = "Operador Ejemplo";
            entry.Valija_Origen = "Valija Ejemplo";
            entry.Partner = "Partner Ejemplo";
            entry.ProveedorTipo_Proveedor = "Tipo Proveedor Ejemplo";
            entry.Referencia = "Referencia Ejemplo";
            entry.valija_Remitente = "Remitente Ejemplo";
            entry.Valija_Obs = "Observaciones Valija Ejemplo";
            entry.Ruc = "RUC Ejemplo";
            entry.Sistema_Origen = "Sistema Ejemplo";
            entry.Status_Documentos = "Status Ejemplo";
            entry.Valor = "1000.00";
            entry.Usuario_edita = "Usuario Ejemplo";
            entry.Fecha_edita = "2024-06-25";
            entry.Indices_editados = "Indices Ejemplo";
            entry.TipodeDocumento = "Tipo Documento Ejemplo";
            entry.Caja_Paquete = "Caja Ejemplo";
            entry.Cod_Empresa = "Empresa Ejemplo";
            entry.Tipo_Orden = "Tipo Orden Ejemplo";
            entry.Cod_Pago = "Pago Ejemplo";
            entry.Version_Registro = "1.0";
            entry.Adicional_2 = "Adicional 2 Ejemplo";
            entry.Adicional_3 = "Adicional 3 Ejemplo";

            _service.Add(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetById(1);

            entry.Motivo_Rechazo = "Nombre modificado";

            _service.Update(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.Bienes_Recibidos}, {item.Ciudad}, {item.Origen_Documento}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(1);
            Console.WriteLine($"{item.Bienes_Recibidos}, {item.Ciudad}, {item.Origen_Documento}");
        }

    }
}
