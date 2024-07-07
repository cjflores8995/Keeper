using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;
using CRD.UI.Windows.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.ControladorAplicacion
{
    public class IvaController
    {
        private CRD_IvaServicio servicio;
        public IvaController()
        {
            servicio = new CRD_IvaServicio();
        }
        public bool InsertarIva(IvaVistaModelo nuevoIvaVistaModelo)
        {
            CRD_Iva nuevoIva = new CRD_Iva();
            try
            {
                nuevoIva.ValorIva = nuevoIvaVistaModelo.ValorIva;
                nuevoIva.Activo = nuevoIvaVistaModelo.Activo ?? true;
                servicio.Add(nuevoIva);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool EliminarIva(int id)
        {

            try
            {
                servicio.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool ActualizarIva(IvaVistaModelo nuevoIvaVistaModelo)
        {
            CRD_Iva nuevoIva = new CRD_Iva();
            try
            {
                nuevoIva.ValorIva = nuevoIvaVistaModelo.ValorIva;
                nuevoIva.Activo = nuevoIvaVistaModelo.Activo ?? true;
                nuevoIva.IdIva = nuevoIvaVistaModelo.IdIva;
                servicio.Modify(nuevoIva);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public IEnumerable<IvaVistaModelo> ListarIva()
        {
            var listaIva = servicio.GetAll();
            List<IvaVistaModelo> listaVistaModelo = new List<IvaVistaModelo>();
            foreach (var item in listaIva)
            {
                listaVistaModelo.Add(new IvaVistaModelo
                {
                    IdIva = item.IdIva,
                    ValorIva = item.ValorIva,
                    Activo = item.Activo,
                });
            }   
            return listaVistaModelo;
        }
    }
}
