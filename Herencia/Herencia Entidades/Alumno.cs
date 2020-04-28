using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Entidades
{
    internal class Alumno : Persona // La clase hija tiene no puede tener la misma visibilidad que la clase padre
    {
        //aca hago un constructor
        public Alumno():base()//con base, llamo al constructor de la clase padre
        {

        }

    }
}
