using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Models
{
    public class Genero
    {
        public int Id_genero { get; set; }
        public string Descripcion { get; set; }

        public Genero(int id_genero, string descripcion)
        {
            Id_genero = id_genero;
            Descripcion = descripcion;
        }

        public Genero()
        {
            Id_genero = 0;
            Descripcion = string.Empty;
        }

        public override string ToString()
        {
            return Descripcion.ToString();
        }
    }
}
