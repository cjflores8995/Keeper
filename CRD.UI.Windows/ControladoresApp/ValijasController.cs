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
    public class ValijasController
    {
        private CRD_ValijasServicio servicio;
        public ValijasController()
        {
            servicio = new CRD_ValijasServicio();
        }
        public bool InsertarValijas(ValijasVistaModelo nuevoValijasVistaModelo)
        {
            CRD_Valijas nuevoValijas = new CRD_Valijas();
            try
            {
                nuevoValijas.IdBitacora = nuevoValijasVistaModelo.IdBitacora;
                nuevoValijas.Fecha = nuevoValijasVistaModelo.Fecha;
                nuevoValijas.Origen = nuevoValijasVistaModelo.Origen;
                nuevoValijas.Remitente = nuevoValijasVistaModelo.Remitente;
                nuevoValijas.Centro = nuevoValijasVistaModelo.Centro;
                nuevoValijas.OBSV = nuevoValijasVistaModelo.OBSV;
                nuevoValijas.Activo = nuevoValijasVistaModelo.Activo ?? true;
                servicio.Add(nuevoValijas);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool EliminarValijas(int id)
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
        public bool ActualizarValijas(ValijasVistaModelo nuevoValijasVistaModelo)
        {
            CRD_Valijas nuevoValijas = new CRD_Valijas();
            try
            {
                nuevoValijas.IdBitacora = nuevoValijasVistaModelo.IdBitacora;
                nuevoValijas.Fecha = nuevoValijasVistaModelo.Fecha;
                nuevoValijas.Origen = nuevoValijasVistaModelo.Origen;
                nuevoValijas.Remitente = nuevoValijasVistaModelo.Remitente;
                nuevoValijas.Centro = nuevoValijasVistaModelo.Centro;
                nuevoValijas.OBSV = nuevoValijasVistaModelo.OBSV;
                nuevoValijas.Activo = nuevoValijasVistaModelo.Activo ?? true;
                nuevoValijas.IdValija = nuevoValijasVistaModelo.IdValija;
                servicio.Modify(nuevoValijas);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public IEnumerable<ValijasVistaModelo> ListarValijas()
        {
            var listaValijas = servicio.GetAll();
            List<ValijasVistaModelo> listaVistaModelo = new List<ValijasVistaModelo>();
            foreach (var item in listaValijas)
            {
                listaVistaModelo.Add(new ValijasVistaModelo
                {
                    IdValija = item.IdValija,
                    IdBitacora = item.IdBitacora,
                    Fecha = item.Fecha,
                    Origen = item.Origen,
                    Remitente = item.Remitente,
                    Centro = item.Centro,
                    OBSV = item.OBSV,
                    Activo = item.Activo,
                });
            }
            return listaVistaModelo;
        }
    }
}
