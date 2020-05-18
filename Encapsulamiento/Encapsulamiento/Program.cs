using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Pepe", "Peposo", 10, 201);
            Alumno alumno2 = new Alumno("Mariano", "Luis", 12, 563);

            //Console.WriteLine(alumno1.GetNombre());


            ////usando propiedades
            //string miAuxiliar = string.Empty;
            //miAuxiliar = alumno1.Nombre;//aca obtengo el nombre y se lo cargo a mi auxiliar
            //alumno2.Nombre = "Lucas";//aca lo seteo al nombre
            //Aula miAula = new Aula("Matematica");
            //con enumerado seria asi
            //Aula miAula = new Aula(Materias.Laboratorio2);

            //Alumno alumno;
            //alumno = miAula[2];//aca le voy a cargar el alumno que este en la posicion 2 

            //Console.Write(miAula[2].Nombre);//esto lo que haria seria buscar el nombre en esa posicion y mostrarlo,mediante una propiedad
            //INDEXAR UN OBJETO,

            //miAula[2] = new Alumno("Panchita", "Gomez", 22, 689);//aca usa el set y se lo carga al indice que se le pasa

            //EXCEPCIONCES

            //string entrada = Console.ReadLine();
            //try// cuando sabemos que puede haber un error usamos try... si no puede aca va al bloque catch
            //{
            //    alumno2.Edad = int.Parse(entrada);
            //    Aula miAula = new Aula();
            //    miAula.alumnos.Add(new Alumno("Panchito","Perez",11,321));
            //    miAula.alumnos.Add(alumno2);
            //}
            //catch(FormatException fe)//si ve que es del tipo que especificamos.. continua sino sigue buscando
            //{
            //    Console.WriteLine(fe.Message);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            double miValor = 0;
            try
            {
                double res = Dividir(out miValor);

                Console.WriteLine("El resultado es: " + res.ToString());
            }
            catch(Exception e)//EXCEPTION ES GENERICA Y BUSCA EN ALGO GENERICO LO QUE ESTA PASANDO
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Mi valor: " + miValor.ToString());


            Console.ReadKey();
        }

        //static float Dividir()
        static float Dividir(out double valor)
        {
            int numeroUno;
            int numeroDos;

            float salida = 0;
            try//solo funciona si puede hacer el bloque que este adentro
            {
                Console.WriteLine("Ingrese el dividendo: \n");
                string entrada = Console.ReadLine();
                numeroUno = int.Parse(entrada);
                Console.WriteLine("Ingrese el divisor: \n");
                numeroDos = int.Parse(entrada);

                salida = numeroUno / numeroDos;
            }
            catch(FormatException fe)//si dividimos por cero no va a entrar aca, va a buscar en otro lugar
                                    //para ver que hacer y devolver un error
            {
                Console.WriteLine(fe.Message);
            }
            //antes de retornar si tengo un return puedo usar un bloque finally, se ejecuta aunque se haya hecho
            //bien o si entro en el catch. Siempre se va ejecutar si o si
            finally
            {
                valor = salida;
            }
            return salida;
        }
    }
}
