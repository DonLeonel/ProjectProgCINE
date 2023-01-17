﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEApp_BackEnd.Models
{
    internal class Origen
    {
        public int IdOrigen { get; set; }
        public string Descripcion { get; set; }

        public Origen(int idOrigen, string descripcion)
        {
            IdOrigen = idOrigen;
            Descripcion = descripcion;
        }
        public Origen()
        {

        }
    }
}
