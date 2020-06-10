using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInterface
{
    class Prueba :IExplicita
    {
        public bool Implementacion()//implicit
        {
            return false;
        }

        bool IExplicita.Implementacion()//explicita, sirve para diferenciar si hay varias clases que la implementen
        {
            return true;
        }
    }
}
