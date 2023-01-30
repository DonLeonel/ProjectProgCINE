using CINE_BackEnd.Data.Imp;
using CINE_BackEnd.Data.Interfaz;
using CINE_BackEnd.Models;
using CINE_BackEnd.Services.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Services.Imp
{
    public class Service : IService
    {
        private IDAO oDAO;
        
        public Service()
        {
            oDAO = new Dao();
        }

        public bool InsertPeliculas(Pelicula pelicula)
        {
            return oDAO.InsertPeliculas(pelicula);
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

        public DataTable Get(string sp)
        {
            return oDAO.Get(sp);
        }

        public bool UpdatePelicula(Pelicula pelicula)
        {
            return oDAO.UpdatePelicula(pelicula);
        }

        public bool DeletePelicula(int Id)
        {
            return oDAO.DeletePelicula(Id);
        }

        public bool UpdateFuncion(Funcion funcion)
        {
            return oDAO.UpdateFuncion(funcion);
        }
    }
}
