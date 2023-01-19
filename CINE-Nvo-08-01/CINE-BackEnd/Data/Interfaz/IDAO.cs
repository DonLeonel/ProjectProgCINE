using CINE_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Data.Interfaz
{
    internal interface IDAO
    {
        List<Cliente> GetClientes();
        DataTable Get(string sp);
        List<Funcion> GetFunciones();
        List<Reserva> GetReservas();
        List<Pelicula> GetPeliculas();
        List<Reserva> GetReservaXFecha(DateTime desde, DateTime hasta);
        bool InsertCliente(Cliente cliente);
        bool InsertReserva(Reserva reserva);
        bool InsertFactura(Factura factura);
        bool InsertFuncion(Funcion funcion);
        bool InsertPeliculas(Pelicula pelicula);
        bool UpdateCliente(Cliente cliente);
        
    }
}
