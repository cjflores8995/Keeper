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
    public class CRD_ValijasServicio
    {
        readonly ICRD_ValijasRepositorio _repo;
        public CRD_ValijasServicio()
        {
            _repo = new CRD_ValijasRepositorioImpl();
        }

        public void Add(CRD_Valijas entry)
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

        public void Update(CRD_Valijas entry)
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

        public IEnumerable<CRD_Valijas> GetAll()
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

        public CRD_Valijas GetById(int id)
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
    }
}
