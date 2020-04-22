using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro nuevoLibro = new Libro();
            nuevoLibro[5] = "pagina nueva";

            Console.WriteLine(nuevoLibro[2]);//aca le pasamos el indice para que nos muestre eso
            Console.WriteLine(nuevoLibro[1]);
            Console.WriteLine(nuevoLibro[3]);
            Console.WriteLine(nuevoLibro[4]);

            Console.ReadKey();
        }
    }
}
