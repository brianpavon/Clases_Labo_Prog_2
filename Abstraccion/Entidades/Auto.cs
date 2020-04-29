using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Transporte
    {
        private int cantidadPuertas;

        public Auto(ECombustible combustible,ETipo tipo,int cantidadMaximaPasajeros,int cantidadPuertas):base(combustible,tipo,cantidadMaximaPasajeros)
        {
            this.cantidadPuertas = cantidadPuertas;
        }

        public int CantidadPuertas
        {
            get { return this.cantidadPuertas; }
            set { this.cantidadPuertas = value; }
        }

        public override void Frenar()//con override implemento el metodo que heredo de la clase padre
        {
            Console.WriteLine("El chofer piso el freno y puso freno de mano");
        }

        //public override string Mostrar() //LO CORRECTO SERIA SOBRECARGAR EL ToString()
        //{
        //    StringBuilder sb2 = new StringBuilder();
        //    sb2.AppendLine(base.Mostrar());
        //    sb2.AppendLine($"Cantidad de puertas {this.cantidadPuertas}");

        //    return sb2.ToString();
        //}


        public override string ToString()//sobrecargamos el tostring, es lo mas normal que vamos hacer
        {
            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine(base.Mostrar());
            sb2.AppendLine($"Cantidad de puertas {this.cantidadPuertas}");

            return sb2.ToString();

        }
    }
}
