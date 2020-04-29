using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Abstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Transporte miTransporte = new Transporte(ETipo.Aereo, ECombustible.Diesel, 29); no puedo hacerlo porque es abstract esta clase

            //Si hacemos esto:

            List<Transporte> transportes = new List<Transporte>();

            transportes.Add(new Auto(ECombustible.Nafta,ETipo.Terrestre,5,4));

            //Auto miAuto = new Auto(ECombustible.Nafta, ETipo.Terrestre, 3, 3);
            transportes.Add(new Velero(ECombustible.Diesel,ETipo.Martimo,20,5000));
            transportes.Add(new Carreta(ECombustible.TraccionSangre,ETipo.Terrestre,2,4));
            transportes.Add(new Avion(ECombustible.Diesel,ETipo.Aereo,2000,true));

            foreach (Transporte item in transportes)
            {
                item.Frenar();//muestra el metodo implementado en cada clase, porque esta declarado como abstract
                Console.WriteLine(item.Mostrar());//y aca va a mostrar el metodo que se hizo en la clase padre, 
                                                  //si ellas lo modificaron, muestra ese metodo,porque se declaro como virtual
                                                                        
            }

            Console.ReadKey();


        }
    }
}
