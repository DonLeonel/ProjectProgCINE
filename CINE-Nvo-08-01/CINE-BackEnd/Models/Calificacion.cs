using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEApp_BackEnd.Models
{
    internal class Calificacion
    {
        public int IdCalif { get; set; }
        public string Descripcion { get; set; }

        public Calificacion(int idCalif, string descripcion)
        {
            IdCalif = idCalif;
            Descripcion = descripcion;
        }

        public Calificacion()
        {

        }
    }
}
