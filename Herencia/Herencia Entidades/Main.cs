using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Entidades
{
    public class Main
    {
        public static void main()
        {
            Persona pr = new Profesor("nombre");//puedo instanciarlo con la clase que quiero que sea, pero declararla como Persona
            Persona persona = new Alumno();
            //Alumno persona = new Persona(); esto no puede hacerse, clase hija no puede instanciar a la clase padre

            List<Persona> personasCurso = new List<Persona>();

            personasCurso.Add(persona);
            personasCurso.Add(pr);

            Console.WriteLine();
        }

    }
}
