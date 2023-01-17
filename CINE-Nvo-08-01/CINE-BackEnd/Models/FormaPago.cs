using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEApp_BackEnd.Models
{
    internal class FormaPago
    {
        public int IdFormaPago { get; set; }
        public string Descripcion { get; set; }

        public FormaPago(int idFormaPago, string descripcion)
        {
            IdFormaPago = idFormaPago;
            Descripcion = descripcion;
        }
        public FormaPago()
        {

        }
    }
}
