using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class AspNetUsersRepositorioImpl : BaseRepositorioImpl<AspNetUsers>, IAspNetUsersRepositorio
    {
        public AspNetUsers ObtenerUsuarioPorEmail(string email)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = (from obj in db.AspNetUsers
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

        public AspNetUsers ObtenerUsuarioPorId(string id)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = db.AspNetUsers.FirstOrDefault(x => x.Id == id);

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
