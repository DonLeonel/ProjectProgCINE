using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEApp_BackEnd.Models
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }

        public Cliente(int idCliente, string nombre, string apellido, DateTime fechaNac)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;

        }

        public Cliente()
        {
                
        }
   
    }
}
