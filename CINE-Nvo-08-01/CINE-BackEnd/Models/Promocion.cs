using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEApp_BackEnd.Models
{
    internal class Promocion
    {
        public int IdPromocion { get; set; }
        public int Descripcion { get; set; }

        public Promocion(int idPromocion, int descripcion)
        {
            IdPromocion = idPromocion;
            Descripcion = descripcion;
        }

        public Promocion()
        {

        }
    }
}
