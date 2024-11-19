using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.negocio
{
    internal class NegocioService
    {
        NegocioDao negocioDao = new NegocioDao();
        public Negocio crearNegocio(Negocio negocioNuevo)
        {
            try
            {
                Negocio negocio = negocioDao.crearNegocio(negocioNuevo);
                return negocio;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Negocio getNegocio(int id_negocio)
        {
            try
            {
                Negocio negocio = negocioDao.getNegocio(id_negocio);
                return negocio;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Negocio updateNegocio(Negocio negocioActualizado)
        {
            try
            {
                Negocio negocioModif = negocioDao.updateNegocio(negocioActualizado);
                return negocioModif;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Negocio getNegocioByName(string nombre_negocio)
        {
            try
            {
                Negocio negocio = negocioDao.getNegocioByName(nombre_negocio);
                return negocio;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
