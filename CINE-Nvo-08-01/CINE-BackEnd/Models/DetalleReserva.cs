using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Models
{
    public class DetalleReserva
    {
        public int IdDetalleReserva { get; set; }        
        public Funcion Funcion { get; set; }
        public int Cantidad { get; set; }

        public DetalleReserva(int idDetalleReserva, Funcion funcion, int cantidad)
        {
            IdDetalleReserva = idDetalleReserva;
            Funcion = funcion;
            Cantidad = cantidad;
        }
        public DetalleReserva()
        {

        }
    }
}
