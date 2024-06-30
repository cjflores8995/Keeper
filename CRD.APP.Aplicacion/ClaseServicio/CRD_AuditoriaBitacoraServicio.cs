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
    public class CRD_AuditoriaBitacoraServicio
    {

        readonly ICRD_AuditoriaBitacoraRepositorio _repo;
        public CRD_AuditoriaBitacoraServicio()
        {
            _repo = new CRD_AuditoriaBitacoraRepositorioImpl();
        }

        public void Add(CRD_AuditoriaBitacora entry)
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

        public void Modify(CRD_AuditoriaBitacora entry)
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

        public IEnumerable<CRD_AuditoriaBitacora> GetAll()
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

        public CRD_AuditoriaBitacora GetById(int id)
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


        public List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorNombreUsuario(string nombre)
        {
            try
            {
                return _repo.ObtenerAuditoriaBitacoraPorNombreUsuario(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }


        public List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return _repo.ObtenerAuditoriaBitacoraPorRangoFechas(fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }


        public List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorRangoFechasRegistroHistorico(string registroHistorico)
        {
            try
            {
                return _repo.ObtenerAuditoriaBitacoraPorRangoFechasRegistroHistorico(registroHistorico);
    }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }
    }
}