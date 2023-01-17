using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEApp_BackEnd.Models
{
    internal class Factura
    {
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Reserva Reserva { get; set; }
        public FormaPago FormaPago { get; set; }
        public Promocion Promocion { get; set; }

        public List<DetalleFactura> lDetalle;

        public Factura(int idFactura, DateTime fecha, Cliente cliente, Reserva reserva, FormaPago formaPago, Promocion promocion)
        {
            IdFactura = idFactura;
            Fecha = fecha;
            Cliente = cliente;
            Reserva = reserva;
            FormaPago = formaPago;
            Promocion = promocion;
        }
        public Factura()
        {
            lDetalle = new List<DetalleFactura>();
        }

        public void AddDtlleFactura(DetalleFactura dtll)
        {
            lDetalle.Add(dtll);
        }

        public void RemoveDtlleFactura(DetalleFactura dtll)
        {
            lDetalle.Remove(dtll);
        }
    }
}
