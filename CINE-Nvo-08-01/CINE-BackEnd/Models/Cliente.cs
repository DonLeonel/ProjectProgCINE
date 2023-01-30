using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }

        public Cliente()
        {

        }
    }
}
