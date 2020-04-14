using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase4
{
    class Program
    {
        static void Main(string[] args)
        {
            Estante estante = new Estante(5);

            for (int i = 0; i < estante.productos.Length; i++)
            {
                Producto producto = new Producto();
                producto.Ingresar();
                if (estante + producto)
                    Console.WriteLine("Se agregó correctamente");
            }
            Producto prodVacio = new Producto();
            prodVacio.fabricante = "Lucas";
            prodVacio.marca = "Segunda Mano";
            prodVacio.tipo = "Barbijo";
            prodVacio.precio = 250.99f;
            prodVacio.cantidad = 0;
            bool a = estante - prodVacio;
            bool b = estante - (new Producto());
            

            estante.productos[1] = prodVacio;
            //Se generu un array de 1 elemento dentro del objeto estante

            Estante estanteA = prodVacio;
            Array.Copy(estante.productos, estanteA.productos, 5);
            bool c = estanteA - prodVacio;

            //como hacer una matriz o array multidimensional:
            //Ejemplo, mis productos estan ubicados en 4 filas y 5 columnas
            Producto[,] productosEnEstanteria;
            productosEnEstanteria = new Producto[4, 5];

            //para recorrer esto lo puedo hacer asi:
            int j;
            for (int i = 0; i < 4; i++)
            {
                
                for (j = 0; j < 5; j++)
                {
                    //productosEnEstanteria[i, j] = prodVacio;//aca se crea un objeto que apunta al mismo lugar que el original
                    productosEnEstanteria[i, j] = nuevoProducto();//aca si se crea uno nuevo
                }

            }
            

            Producto producto1 = (Producto)"Barbijo";

            //CLASE STRING: tiene varios atributos y metodos que sirven y podemos utilizar
            //String s;//hay que crear el objeto del tipo string para poder utilizar
            //s = new string("hola",);

            //string builder es una clase debo instanciarla primero, crear un objeto
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hola");

            //para ver el string builder
            stringBuilder.ToString();
            


            Console.WriteLine((string)producto1);

            

        }
        static Producto nuevoProducto()
        {
            Producto prodVacio = new Producto();
            prodVacio.fabricante = "Lucas";
            prodVacio.marca = "Segunda Mano";
            prodVacio.tipo = "Barbijo";
            prodVacio.precio = 250.99f;
            prodVacio.cantidad = 0;

            return prodVacio;
        }
    }
}
