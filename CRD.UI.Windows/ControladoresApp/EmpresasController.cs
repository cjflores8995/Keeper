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
    public class EmpresasController
    {
        private CRD_EmpresasServicio servicio;
        public EmpresasController()
        {
            servicio = new CRD_EmpresasServicio();
        }
        public bool InsertarEmpresas(EmpresasVistaModelo nuevoEmpresasVistaModelo)
        {
            CRD_Empresas nuevoEmpresas = new CRD_Empresas();
            try
            {
                nuevoEmpresas.CodigoEmpresa = nuevoEmpresasVistaModelo.CodigoEmpresa;
                nuevoEmpresas.Nombre = nuevoEmpresasVistaModelo.Nombre;
                nuevoEmpresas.Descripcion = nuevoEmpresasVistaModelo.Descripcion;
                nuevoEmpresas.Activo = nuevoEmpresasVistaModelo.Activo ?? true;
                servicio.Add(nuevoEmpresas);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool EliminarEmpresas(int id)
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
        public bool ActualizarEmpresas(EmpresasVistaModelo nuevoEmpresasVistaModelo)
        {
            CRD_Empresas nuevoEmpresas = new CRD_Empresas(); 
            try
            {
                nuevoEmpresas.CodigoEmpresa = nuevoEmpresasVistaModelo.CodigoEmpresa;
                nuevoEmpresas.Nombre = nuevoEmpresasVistaModelo.Nombre;
                nuevoEmpresas.Descripcion = nuevoEmpresasVistaModelo.Descripcion;
                nuevoEmpresas.Activo = nuevoEmpresasVistaModelo.Activo ?? true;
                nuevoEmpresas.IdEmpresa = nuevoEmpresasVistaModelo.IdEmpresa;
                servicio.Modify(nuevoEmpresas);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public IEnumerable<EmpresasVistaModelo> ListarEmpresas()
        {
            var listaEmpresas = servicio.GetAll();
            List<EmpresasVistaModelo> listaVistaModelo = new List<EmpresasVistaModelo>();
            foreach (var item in listaEmpresas)
            {
                listaVistaModelo.Add(new EmpresasVistaModelo
                {
                    IdEmpresa = item.IdEmpresa,
                    CodigoEmpresa = item.CodigoEmpresa,
                    Nombre = item.Nombre,
                    Descripcion = item.Descripcion,
                    Activo = item.Activo,
                });
            }
            return listaVistaModelo;
        }
    }
}
