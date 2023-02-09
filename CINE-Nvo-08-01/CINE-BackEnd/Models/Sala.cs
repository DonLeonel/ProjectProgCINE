using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Models
{
    public class Sala
    {   
        public int IdSala { get; set; }
        public string Tipo { get; set; }
        public Butaca Butacas { get; set; }

        public Sala(int idSala, string tipo)
        {
            IdSala = idSala;
            Tipo = tipo;
        }

        public Sala()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
