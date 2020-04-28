using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Entidades
{
    internal  class Staff : Persona //si escribo asi digo que la clase profesor hereda los atributos de Persona
                                          //sealed, hacemos que la clase no puede ser heredada  
    {
        public Staff(string alumno):base(alumno)
        {

        }

    }
}
