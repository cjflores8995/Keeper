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
    public class DepartamentoController
    {
        private CRD_DepartamentoServicio servicio;
        public DepartamentoController()
        {
            servicio = new CRD_DepartamentoServicio();
        }
        public bool InsertarDepartamento(DepartamentoVistaModelo nuevoDepartamentoVistaModelo)
        {
            CRD_Departamento nuevoDepartamento = new CRD_Departamento();
            try
            {
                nuevoDepartamento.NombreDepartamento = nuevoDepartamentoVistaModelo.NombreDepartamento;
                nuevoDepartamento.Descripcion = nuevoDepartamentoVistaModelo.Descripcion;
                nuevoDepartamento.Activo = nuevoDepartamentoVistaModelo.Activo ?? true;
                servicio.Add(nuevoDepartamento);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool EliminarDepartamento(int id)
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
        public bool ActualizarDepartamento(DepartamentoVistaModelo nuevoDepartamentoVistaModelo)
        {
            CRD_Departamento nuevoDepartamento = new CRD_Departamento(); //objeto de la BD
            try
            {
                nuevoDepartamento.NombreDepartamento = nuevoDepartamentoVistaModelo.NombreDepartamento;
                nuevoDepartamento.Descripcion = nuevoDepartamentoVistaModelo.Descripcion;
                nuevoDepartamento.Activo = nuevoDepartamentoVistaModelo.Activo ?? true;
                nuevoDepartamento.IdDepartamento = nuevoDepartamentoVistaModelo.IdDepartamento;
                servicio.Modify(nuevoDepartamento);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public IEnumerable<DepartamentoVistaModelo> ListarDepartamento()
        {
            var listaDepartamento = servicio.ObtenerElementosActivos();
            List<DepartamentoVistaModelo> listaVistaModelo = new List<DepartamentoVistaModelo>();
            foreach (var item in listaDepartamento)
            {
                listaVistaModelo.Add(new DepartamentoVistaModelo
                {
                    IdDepartamento = item.IdDepartamento,
                    NombreDepartamento = item.NombreDepartamento,
                    Descripcion = item.Descripcion,
                    Activo = item.Activo,
                });
            }
            return listaVistaModelo;
        }
    }
}
