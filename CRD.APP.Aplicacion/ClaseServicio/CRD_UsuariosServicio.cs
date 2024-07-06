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
    public class CRD_UsuariosServicio
    {
        readonly ICRDUsuariosRepositorio _repo;

        public CRD_UsuariosServicio()
        {
            _repo = new CRD_UsuariosRepositorioImpl();
        }

        public void Add(CRD_Usuarios entity)
        {
            _repo.Add(entity);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<CRD_Usuarios> GetAll()
        {
            return _repo.GetAll();
        }

        public CRD_Usuarios GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Modify(CRD_Usuarios entity)
        {
            _repo.Modify(entity);
        }

        public CRD_Usuarios ObtenerUsuarioPorEmail(string email)
        {
            return _repo.ObtenerUsuarioPorEmail(email);
        }

        public CRD_Usuarios ObtenerUsuarioPorId(int id)
        {
            return _repo.ObtenerUsuarioPorId(id);
        }
    }
}
