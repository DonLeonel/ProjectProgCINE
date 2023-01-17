using CINEApp_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Services.Interfaz
{
    internal interface IService
    {
        List<Cliente> GetClientes();
        List<Funcion> GetFunciones();
        List<Reserva> GetReservas();
        List<Pelicula> GetPeliculas();
        List<Reserva> GetReservaXFecha(DateTime desde, DateTime hasta);
        bool InsertCliente(Cliente cliente);
        bool InsertReserva(Reserva reserva);
        bool InsertFactura(Factura factura);
        bool InsertFuncion(Funcion funcion);
        bool EjecutarInsertPeliculas(Pelicula pelicula);
        bool UpdateCliente(Cliente cliente);
    }
}
