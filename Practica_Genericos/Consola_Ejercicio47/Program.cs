using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_47;

namespace Consola_Ejercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<Equipo> torneoFutbol = new Torneo<Equipo>("Apertura 2020");
            Torneo<Equipo> torneoBasquet = new Torneo<Equipo>("Nacionales Argentina");

            EquipoBasquet equipoBasquetUno = new EquipoBasquet("Salchipapa",DateTime.Parse("02/12/2002"));
            EquipoBasquet equipoBasquetDos = new EquipoBasquet("Galacticos",DateTime.Parse("15/05/2001"));
            EquipoBasquet equipoBasquetTres = new EquipoBasquet("Los Perros",DateTime.Parse("10/04/2020"));
            EquipoBasquet equipoBasquetCuatro = new EquipoBasquet("Achupallas", DateTime.Parse("12/08/2016"));

            EquipoFutbol equipoFutbolUno = new EquipoFutbol("Los Humildes",DateTime.Parse("11/05/2003"));
            EquipoFutbol equipoFutbolDos = new EquipoFutbol("Toma pa Vo",DateTime.Parse("10/01/1964"));
            EquipoFutbol equipoFutbolTres = new EquipoFutbol("Gigantes",DateTime.Parse("20/09/1990"));
            EquipoFutbol equipoFutbolCuatro = new EquipoFutbol("Rochos S.A", DateTime.Parse("26/01/1990"));

            torneoBasquet += equipoBasquetDos;
            torneoBasquet += equipoBasquetUno;
            torneoBasquet += equipoBasquetTres;
            torneoBasquet += equipoBasquetDos;
            torneoBasquet += equipoBasquetCuatro;

            torneoFutbol += equipoFutbolUno;
            torneoFutbol += equipoFutbolDos;
            torneoFutbol += equipoFutbolTres;
            torneoFutbol += equipoFutbolCuatro;
            torneoFutbol += equipoFutbolCuatro;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadKey();
            
        }
    }
}
