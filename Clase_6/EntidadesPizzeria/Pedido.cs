using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPizzeria
{
    public class Pedido
    {
        public bool envia;
        public DateTime horaIngreso;
        public DateTime horaRetiro;
        public Pizza[] pizzas;
        Cliente cliente;

        private Pedido(Cliente cliente)//creo el cliente y el array de pizzas
        {
            this.cliente = cliente;
            this.pizzas = new Pizza[8];//creo el array con esta cantidad maxima
            
        }

        public static implicit operator Pedido(Cliente cliente)
        {
            Pedido aux = new Pedido(cliente);

            return aux;
        }

        public static bool operator + (Pedido pedido, Pizza pizza)
        {
            for (int i = 0; i < pedido.pizzas.Length; i++)//buscar que exista la pizza en el array de pizzas
            {//si existe y son iguales las suma
                if(pedido.pizzas[i] + pizza)
                {
                    return true;
                }
            }
             //agregar la pizza si no existe          
            for (int i = 0; i < pedido.pizzas.Length; i++)
            {
                if(pedido.pizzas[i] is null)
                {
                    pedido.pizzas[i] = pizza;
                    return true;                    
                }
            }
            return false;
        }
        
    }
}
