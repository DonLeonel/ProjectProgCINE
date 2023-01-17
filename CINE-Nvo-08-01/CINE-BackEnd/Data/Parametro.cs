using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINEApp_BackEnd.Data
{
    internal class Parametro
    {
        public string key { get; set; }
        public object value { get; set; }

        public Parametro(string key, object value)
        {
            this.key = key;
            this.value = value;
        }
        public Parametro()
        {

        }
    }
}
