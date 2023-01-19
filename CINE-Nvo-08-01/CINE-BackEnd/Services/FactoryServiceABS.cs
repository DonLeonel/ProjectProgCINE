using CINE_BackEnd.Services.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_BackEnd.Services
{
    public abstract class FactoryServiceABS
    {
        public abstract IService GetService();
    }
}
