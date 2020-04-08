using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_y_explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje miPersonaje = "PANCHITO";

            miPersonaje = true;

            string nombrePersonaje = (string)miPersonaje;

        }
    }
}
