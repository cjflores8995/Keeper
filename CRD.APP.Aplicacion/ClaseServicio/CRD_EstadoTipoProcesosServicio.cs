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
    public class CRD_EstadoTipoProcesosServicio
    {
        readonly ICRD_EstadoTipoProcesosRepositorio _repo;
        public CRD_EstadoTipoProcesosServicio()
        {
            _repo = new CRD_EstadoTipoProcesosRepositorioImpl();
        }

        public void Add(CRD_EstadoTipoProcesos entry)
        {
            try
            {
                _repo.Add(entry);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }

        }

        public void Modify(CRD_EstadoTipoProcesos entry)
        {
            try
            {
                _repo.Modify(entry);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }

        }

        public IEnumerable<CRD_EstadoTipoProcesos> GetAll()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public CRD_EstadoTipoProcesos GetById(int id)
        {
            try
            {
                return _repo.GetById(id);
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
                _repo.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public CRD_EstadoTipoProcesos buscarPorNombre(string nom)
        {
            try
            {
                return _repo.buscarPorNombre(nom);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: Error no pasa,", ex);
            }
        }

    }
}
