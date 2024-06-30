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
    public class AspNetUsersServicio
    {
        readonly IAspNetUsersRepositorio _repo;

        public AspNetUsersServicio()
        {
            _repo = new AspNetUsersRepositorioImpl();
        }

        public void Add(AspNetUsers entity)
        {
            _repo.Add(entity);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<AspNetUsers> GetAll()
        {
            return _repo.GetAll();
        }

        public AspNetUsers GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Modify(AspNetUsers entity)
        {
            _repo.Modify(entity);
        }

        public AspNetUsers ObtenerUsuarioPorEmail(string email)
        {
            return _repo.ObtenerUsuarioPorEmail(email);
        }

        public AspNetUsers ObtenerUsuarioPorId(string id)
        {
            return _repo.ObtenerUsuarioPorId(id);
        }
    }
}
