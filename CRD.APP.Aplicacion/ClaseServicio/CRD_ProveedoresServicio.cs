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
    public class CRD_ProveedoresServicio
    {
        readonly ICRD_ProveedoresRepositorio _repo;
        public CRD_ProveedoresServicio()
        {
            _repo = new CRD_ProveedoresRepositorioImpl();
        }

        public void Add(CRD_Proveedores entry)
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

        public void Modify(CRD_Proveedores entry)
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

        public IEnumerable<CRD_Proveedores> GetAll()
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

        public CRD_Proveedores GetById(int id)
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

        public CRD_Proveedores buscarPorCodProveedor(String codProveedor)
        {
            try
            {
                return _repo.buscarPorCodProveedor(codProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo encontrar el registro", ex);
            }
        }

        public List<CRD_Proveedores> buscarPorRUC(string rucCedula)
        {
            try
            {
                return _repo.buscarPorRUC(rucCedula);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: No se pudo mostrar registro,", ex);
            }
        }

        public List<CRD_Proveedores> buscarPorRazonSocial(string razonSocial)
        {
            try
            {
                return _repo.buscarPorRazonSocial(razonSocial);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: No se pudo mostrar registro,", ex);
            }
        }
    }
}
