﻿using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_CajasRepositorioImpl : BaseRepositorioImpl<CRD_Cajas>, ICRD_CajasRepositorio
    {
        public List<CRD_Cajas> ObtenerCajasPorNomre(string nombreCaja)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = (from obj in db.CRD_Cajas
                                  where obj.NombreCaja == nombreCaja
                                  select obj).ToList();

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
