using CINE_BackEnd.Services.Interfaz;
using CINEApp_BackEnd.Data.Imp;
using CINEApp_BackEnd.Data.Interfaz;
using CINEApp_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Services.Imp
{
    internal class Service : IService
    {
        private IDAO oDAO;
        
        public Service()
        {
            oDAO = new Dao();
        }

        public bool EjecutarInsertPeliculas(Pelicula pelicula)
        {
            return oDAO.EjecutarInsertPeliculas(pelicula);
        }

        public List<Cliente> GetClientes()
        {
            return oDAO.GetClientes();
        }

        public List<Funcion> GetFunciones()
        {
            return oDAO.GetFunciones();
        }

        public List<Pelicula> GetPeliculas()
        {
            return oDAO.GetPeliculas();
        }

        public List<Reserva> GetReservas()
        {
            return oDAO.GetReservas();
        }

        public List<Reserva> GetReservaXFecha(DateTime desde, DateTime hasta)
        {
            return oDAO.GetReservaXFecha(desde, hasta);
        }

        public bool InsertCliente(Cliente cliente)
        {
            return oDAO.InsertCliente(cliente);
        }

        public bool InsertFactura(Factura factura)
        {
            return oDAO.InsertFactura(factura);
        }

        public bool InsertFuncion(Funcion funcion)
        {
            return oDAO.InsertFuncion(funcion);
        }

        public bool InsertReserva(Reserva reserva)
        {
            return oDAO.InsertReserva(reserva);
        }

        public bool UpdateCliente(Cliente cliente)
        {
            return oDAO.UpdateCliente(cliente);
        }
    }
}
