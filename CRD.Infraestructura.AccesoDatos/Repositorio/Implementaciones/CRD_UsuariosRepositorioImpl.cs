using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_UsuariosRepositorioImpl : BaseRepositorioImpl<CRD_Usuarios>, ICRD_UsuariosRepositorio
    {
        public CRD_Usuarios ObtenerUsuarioPorEmail(string email)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = (from obj in db.CRD_Usuarios
                                  where obj.Email.ToLower().Equals(email.ToLower())
                                  select obj).FirstOrDefault();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public CRD_Usuarios ObtenerUsuarioPorId(int id)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = db.CRD_Usuarios.FirstOrDefault(x => x.Id == id);

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }
    }
}
