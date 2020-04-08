using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Debemos realizar la carga de 5(cinco) productos de prevención de contagio,
                de cada una debo obtener los siguientes datos:
                el tipo (validar "barbijo" , "jabón" o "alcohol") ,
                el precio (validar entre 100 y 300),
                la cantidad de unidades (no puede ser 0 o negativo y no debe superar las 1000 unidades),
                la Marca
                y el fabricante
             */

            Producto[] productos = new Producto[5];//aca creamos el array de productos

            string tipo = String.Empty;//lo cargo en vacio
            float precio = 0;
            int cantUnidades = 0;
            string marca = String.Empty;
            string fabricante = String.Empty;

            for (int i = 0; i <= productos.Length; i++)
            {
                //tambien puedo hacer productos.tipo
              
                Console.WriteLine("Ingrese el tipo de producto ");
                tipo = Console.ReadLine(); // tambien puedo hacer tipo = productos.tipo
                Console.WriteLine("Ingrese el precio del producto ");
                //precio = float.Parse(Console.ReadLine()); esto no es lo mejor, lo correcto es con tryParse y un while,
                //esto devuelve true si pudo pasarlo a float
                while (!float.TryParse(Console.ReadLine(), out precio) && precio < 100 || precio > 300)
                {
                    Console.WriteLine("ERROR. Reingrese el precio");
                    float.TryParse(Console.ReadLine(), out precio);
                }


                Console.WriteLine("Ingrese cantidad de unidades ");
                //cantUnidades = int.Parse(Console.ReadLine());
                while(!int.TryParse(Console.ReadLine(),out cantUnidades) || cantUnidades < 0 && cantUnidades > 1000)
                { 
                    Console.WriteLine("ERROR. Reingrese las cantidades");
                    int.TryParse(Console.ReadLine(), out cantUnidades);

                }           
                
                Console.WriteLine("Ingrese la marca del producto ");
                marca = Console.ReadLine();
                Console.WriteLine("Ingrese el fabricante producto ");
                fabricante = Console.ReadLine();

                productos[i] = new Producto(tipo,precio,cantUnidades,marca,fabricante);
            }

            Console.ReadKey();

        }
    }
}
