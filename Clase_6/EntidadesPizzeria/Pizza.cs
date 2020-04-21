using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPizzeria
{
    public class Pizza
    {
        private double cantidad;
        private string gusto;
        private string tipoCoccion;

        public Pizza(double cantidad,string gusto,string tipoCoccion)//no tiene sentido sobrecargar constructor
        {
            this.cantidad = cantidad;
            this.gusto = gusto;
            this.tipoCoccion = tipoCoccion;
        }

        public static bool operator == (Pizza pizzaUno, Pizza pizzaDos)
        {
            /*bool iguales = false; esto es el camino largo
            if(pizza.tipoCoccion == pizza2.tipoCoccion && pizza.gusto == pizza2.gusto)
            {
                iguales = true;
            }
            return iguales;*/
            //este es el camino largo
            if(!(pizzaUno is null))
            {
                return pizzaUno.gusto == pizzaDos.gusto && pizzaUno.tipoCoccion == pizzaDos.tipoCoccion;
            }
            return false;
            
        }

        public static bool operator != (Pizza pizza, Pizza pizzaDos)
        {
          
            return !(pizza == pizzaDos);
        }

        public static bool operator +(Pizza pizza,Pizza pizzaDos)
        {
            if(pizza == pizzaDos)
            {
                //pizza.cantidad = pizza.cantidad + pizzaDos.cantidad;
                pizza.cantidad += pizzaDos.cantidad;//esto es lo abreviado
                return true;
            }
            return false;
            
        }


    }
}
