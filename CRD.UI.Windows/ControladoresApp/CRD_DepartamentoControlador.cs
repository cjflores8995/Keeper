using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;
using CRD.UI.Windows.VistaModelo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.ControladoresApp
{
    public class CRD_DepartamentoControlador
    {
        private readonly CRD_DepartamentoServicio servicio;

        public CRD_DepartamentoControlador()
        {
            servicio = new CRD_DepartamentoServicio();
        }

        public List<CRD_DepartamentoVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_DepartamentoVistaModelo> result = new List<CRD_DepartamentoVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_DepartamentoVistaModelo entry = new CRD_DepartamentoVistaModelo()
                        {
                            IdDepartamento = item.IdDepartamento,
                            NombreDepartamento = item.NombreDepartamento,
                            Descripcion = item.Descripcion,
                            Activo = item.Activo
                        };

                        result.Add(entry);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }
        }
    }
}
