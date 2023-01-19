using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Models
{
    public class DetalleFactura
    {
        public int IdFactura { get; set; }
        public int IdDetalleFactura { get; set; }
        public Funcion Funcion { get; set; }
        public int Cantidad { get; set; }

        public DetalleFactura(int idFactura, int idDetalleFactura, Funcion funcion, int cantidad)
        {
            IdFactura = idFactura;
            IdDetalleFactura = idDetalleFactura;
            Funcion = funcion;
            Cantidad = cantidad;
        }

        public DetalleFactura()
        {

        }
    }
}
