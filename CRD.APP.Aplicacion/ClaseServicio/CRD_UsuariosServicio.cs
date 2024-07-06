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
        readonly ICRDUsuariosRepositorio repo;

        public CRD_UsuariosServicio()
        {
            repo = new CRD_UsuariosRepositorioImpl();
        }

        public void Add(CRD_Usuarios entity)
        {
            repo.Add(entity);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public IEnumerable<CRD_Usuarios> GetAll()
        {
            return repo.GetAll();
        }

        public CRD_Usuarios GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Modify(CRD_Usuarios entity)
        {
            repo.Modify(entity);
        }

        public CRD_Usuarios ObtenerUsuarioPorEmail(string email)
        {
            return repo.ObtenerUsuarioPorEmail(email);
        }

        public CRD_Usuarios ObtenerUsuarioPorId(int id)
        {
            return repo.ObtenerUsuarioPorId(id);
        }
    }
}
