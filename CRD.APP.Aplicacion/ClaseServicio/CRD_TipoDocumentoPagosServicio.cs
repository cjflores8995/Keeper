using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.APP.Aplicacion.ClaseServicio
{
    public class CRD_TipoDocumentoPagosServicio
    {
        readonly ICRD_TipoDocumentoPagosRepositorio repo;
        public CRD_TipoDocumentoPagosServicio()
        {
            repo = new CRD_TipoDocumentoPagosRepositorioImpl();
        }

        public void Add(CRD_TipoDocumentoPagos entry)
        {
            try
            {
                repo.Add(entry);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }

        }

        public void Modify(CRD_TipoDocumentoPagos entry)
        {
            try
            {
                repo.Modify(entry);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }

        }

        public IEnumerable<CRD_TipoDocumentoPagos> GetAll()
        {
            try
            {
                return repo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public CRD_TipoDocumentoPagos GetById(int id)
        {
            try
            {
                return repo.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                repo.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public CRD_TipoDocumentoPagos buscarPorNombre(string nombre)
        {
            try
            {
                return repo.buscarPorNombre(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo encontrar el registro", ex);
            }
        }
    }
}
