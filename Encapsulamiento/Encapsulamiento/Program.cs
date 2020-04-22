using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alumno alumno1 = new Alumno("Pepe", "Peposo", 10, 201);
            //Alumno alumno2 = new Alumno("Mariano", "Luis", 12, 563);

            //Console.WriteLine(alumno1.GetNombre());


            ////usando propiedades
            //string miAuxiliar = string.Empty;
            //miAuxiliar = alumno1.Nombre;//aca obtengo el nombre y se lo cargo a mi auxiliar
            //alumno2.Nombre = "Lucas";//aca lo seteo al nombre
            //Aula miAula = new Aula("Matematica");
            //con enumerado seria asi
            Aula miAula = new Aula(Materias.Laboratorio2);

            Alumno alumno;
            alumno = miAula[2];//aca le voy a cargar el alumno que este en la posicion 2 

            Console.Write(miAula[2].Nombre);//esto lo que haria seria buscar el nombre en esa posicion y mostrarlo,mediante una propiedad
            //INDEXAR UN OBJETO,

            miAula[2] = new Alumno("Panchita", "Gomez", 22, 689);//aca usa el set y se lo carga al indice que se le pasa

            Console.ReadKey();
        }
    }
}
