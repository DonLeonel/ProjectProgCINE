using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEApp_BackEnd.Models
{
    internal class Funcion
    {
        public int IdFuncion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public double Precio { get; set; }
        public Pelicula Pelicula { get; set; }
        public Sala Sala { get; set; }
        public bool Agotado { get; set; }

        public Funcion(int idFuncion, DateTime fecha, DateTime horaInicio, double precio, Pelicula pelicula, Sala sala, bool agotado)
        {
            IdFuncion = idFuncion;
            Fecha = fecha;
            HoraInicio = horaInicio;
            Precio = precio;
            Pelicula = pelicula;
            Sala = sala;
            Agotado = agotado;
        }
        public Funcion()
        {

        }
    }
}
