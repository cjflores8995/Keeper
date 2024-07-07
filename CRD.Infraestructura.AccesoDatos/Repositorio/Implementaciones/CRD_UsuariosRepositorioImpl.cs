using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using CRD.Infraestructura.CrossCuting.Cache;
using CRD.Infraestructura.CrossCuting.Messages;

using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public bool LoginUsuario(string usuario, string password)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    CRD_Usuarios usuarioDb = db.CRD_Usuarios.FirstOrDefault(x => x.NombreUsuario.ToLower() == usuario.ToLower().Trim() && x.Activo == true);

                    if (usuarioDb == null)
                    {
                        return false;
                    }
                    else
                    {
                        string paswordHash = Funcionalidades.ConvertirStringEnSHA256(password);

                        if (usuarioDb.PasswordHash.ToLower().Equals(paswordHash))
                        {
                            UsuarioLoginCache.Id = usuarioDb.Id;
                            UsuarioLoginCache.Nombre = usuarioDb.Nombre;
                            UsuarioLoginCache.Apellido = usuarioDb.Apellido;
                            UsuarioLoginCache.NombreUsuario = usuarioDb.NombreUsuario;

                            var rolesUsuario = usuarioDb.CRD_UsuarioRoles.ToList();

                            if (rolesUsuario.Any())
                            {
                                foreach (var item in rolesUsuario)
                                {
                                    var rol = new UsuarioRoles();
                                    rol.Id = item.UserId;
                                    rol.Nombre = item.CRD_Roles.Name;

                                    UsuarioLoginCache.UsuarioRoles.Add(rol);
                                }
                            }

                            usuarioDb.FechaUltimoAcceso = DateTime.Now;
                            db.SaveChanges();

                            return true;
                        } else
                        {
                            return false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_Usuarios> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_Usuarios.Include("CRD_Departamento").Include("CRD_Cargo").Include("CRD_Ciudad").Where(x => x.Activo == true).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public bool EliminadoLogico(int id)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var elemento = db.CRD_Usuarios.FirstOrDefault(x => x.Id == id);

                    if (elemento != null)
                    {
                        elemento.Activo = false;
                        var result = db.SaveChanges();

                        return result > 0;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public bool InsertarUsuario(CRD_Usuarios obj)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    obj.CRD_Cargo = db.CRD_Cargo.FirstOrDefault(x => x.IdCargo == obj.IdCargo);
                    obj.CRD_Ciudad = db.CRD_Ciudad.FirstOrDefault(x => x.IdCiudad == obj.IdCiudad);
                    obj.CRD_Departamento = db.CRD_Departamento.FirstOrDefault(x => x.IdDepartamento == obj.IdDepartamento);


                    var usuario = db.CRD_Usuarios.Add(obj);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public bool ActualizarUsuario(CRD_Usuarios obj)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var usuario = db.CRD_Usuarios.FirstOrDefault(x => x.Id == obj.Id);

                    if(usuario == null)
                    {
                        return false;

                    }

                    usuario.CRD_Cargo = db.CRD_Cargo.FirstOrDefault(x => x.IdCargo == obj.IdCargo);
                    usuario.CRD_Ciudad = db.CRD_Ciudad.FirstOrDefault(x => x.IdCiudad == obj.IdCiudad);
                    usuario.CRD_Departamento = db.CRD_Departamento.FirstOrDefault(x => x.IdDepartamento == obj.IdDepartamento);

                    usuario.Nombre = obj.Nombre;
                    usuario.Apellido = obj.Apellido;
                    usuario.IdCargo = obj.IdCargo;
                    usuario.IdDepartamento = obj.IdDepartamento;
                    usuario.IdCiudad = obj.IdCiudad;
                    usuario.Email = obj.Email;

                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }
    }
}
