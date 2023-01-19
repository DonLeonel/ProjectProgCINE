using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Models
{
    public class Reserva
    {
        public int Id_reserva { get; set; }
        public DateTime FechaReserva { get; set; }
        public Cliente Cliente { get; set; }
      
        public List<DetalleReserva> Ldetalle;

        public Reserva(int id_reserva, DateTime fechaReserva, Cliente cliente)
        {
            Id_reserva = id_reserva;
            FechaReserva = fechaReserva;
            Cliente = cliente;
        }
        public Reserva()
        {
            Ldetalle = new List<DetalleReserva>();
        }

        public void AddDtlleReserva(DetalleReserva dtllReserva)
        {
            Ldetalle.Add(dtllReserva);
        }  
        
        public void RemoveDtlleReserva(DetalleReserva dtllReserva)
        {
            Ldetalle.Remove(dtllReserva);
        }

    }
}
