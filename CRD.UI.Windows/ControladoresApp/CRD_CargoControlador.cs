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
    public class CRD_CargoControlador
    {
        private readonly CRD_CargoServicio servicio;

        public CRD_CargoControlador()
        {
            servicio = new CRD_CargoServicio();
        }

        public bool Insertar(CRD_CargoVistaModelo obj)
        {
            try
            {
                CRD_Cargo entry = new CRD_Cargo();
                entry.NombreCargo = obj.NombreCargo;
                entry.Descripcion = obj.Descripcion;
                entry.Activo = obj.Activo;

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_CargoVistaModelo obj)
        {
            try
            {
                CRD_Cargo entry = new CRD_Cargo();
                entry.IdCargo = obj.IdCargo;
                entry.NombreCargo = obj.NombreCargo;
                entry.Descripcion = obj.Descripcion;
                entry.Activo = obj.Activo;

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Eliminar(int idObj)
        {
            try
            {
                servicio.Delete(idObj);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<CRD_CargoVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_CargoVistaModelo> result = new List<CRD_CargoVistaModelo>();

                var query = servicio.ObtenerCargosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_CargoVistaModelo entry = new CRD_CargoVistaModelo()
                        {
                            IdCargo = item.IdCargo,
                            NombreCargo = item.NombreCargo,
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
