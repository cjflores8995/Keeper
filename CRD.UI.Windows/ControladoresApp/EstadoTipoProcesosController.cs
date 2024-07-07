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
    public class EstadoTipoProcesosController
    {
        private CRD_EstadoTipoProcesosServicio servicio;
        public EstadoTipoProcesosController()
        {
            servicio = new CRD_EstadoTipoProcesosServicio();
        }
        public bool InsertarEstadoTipoProcesos(EstadoTipoProcesosVistaModelo nuevoEstadoTipoProcesosVistaModelo)
        {
            CRD_EstadoTipoProcesos nuevoEstadoTipoProcesos = new CRD_EstadoTipoProcesos();
            try
            {
                nuevoEstadoTipoProcesos.Nombre = nuevoEstadoTipoProcesos.Nombre;
                nuevoEstadoTipoProcesos.Descripcion = nuevoEstadoTipoProcesos.Descripcion;
                nuevoEstadoTipoProcesos.Activo = nuevoEstadoTipoProcesos.Activo;
                servicio.Add(nuevoEstadoTipoProcesos);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool EliminarEstadoTipoProcesos(int id)
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
        public bool ActualizarEstadoTipoProcesos(EstadoTipoProcesosVistaModelo nuevoEstadoTipoProcesosVistaModelo)
        {
            CRD_EstadoTipoProcesos nuevoEstadoTipoProcesos = new CRD_EstadoTipoProcesos();
            try
            {
                nuevoEstadoTipoProcesos.Nombre = nuevoEstadoTipoProcesos.Nombre;
                nuevoEstadoTipoProcesos.Descripcion = nuevoEstadoTipoProcesos.Descripcion;
                nuevoEstadoTipoProcesos.Activo = nuevoEstadoTipoProcesos.Activo;
                nuevoEstadoTipoProcesos.IdEstadoTipoProceso = nuevoEstadoTipoProcesos.IdEstadoTipoProceso;
                servicio.Modify(nuevoEstadoTipoProcesos);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public IEnumerable<EstadoTipoProcesosVistaModelo> ListarEstadoTipoProcesos()
        {
            var listaEstadoTipoProcesos = servicio.GetAll();
            List<EstadoTipoProcesosVistaModelo> listaVistaModelo = new List<EstadoTipoProcesosVistaModelo>();
            foreach (var item in listaEstadoTipoProcesos)
            {
                listaVistaModelo.Add(new EstadoTipoProcesosVistaModelo
                {
                    IdEstadoTipoProceso = item.IdEstadoTipoProceso,
                    Nombre = item.Nombre,
                    Descripcion = item.Descripcion,
                    Activo = item.Activo,
                });
            }
            return listaVistaModelo;
        }
    }
}
