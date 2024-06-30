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
    public class CRD_AnalistasServicio
    {

        readonly ICRD_AnalistasRepositorio _repo;
        public CRD_AnalistasServicio()
        {
            _repo = new CRD_AnalistasRepositorioImpl();
        }

        public void Add(CRD_Analistas entry)
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

        public void Modify(CRD_Analistas entry)
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

        public IEnumerable<CRD_Analistas> GetAll()
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

        public CRD_Analistas GetById(int id)
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

        public CRD_Analistas buscarPorIdAnalista(int IdAnalista)
        {
            try
            {
                return _repo.buscarPorIdAnalista(IdAnalista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: No se pudo los registros,", ex);
            }
        }

        public string buscarPorIdProceso(int IdProceso)
        {
            try
            {
                return _repo.buscarPorIdProceso( IdProceso);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo encontrar el registro", ex);
            }
        }
    }
}
