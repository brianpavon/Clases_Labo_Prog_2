using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Velero : Transporte
    {
        private double precio;

        public Velero(ECombustible combustible,ETipo tipo,int cantidadMaximaPasajeros, double precio):base(combustible,tipo,cantidadMaximaPasajeros)
        {
            this.precio = precio;
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public override void Frenar()
        {
            Console.WriteLine("Guarda la vela, y frena lentamente con la marea,y tira ancla");
        }
    }
}
