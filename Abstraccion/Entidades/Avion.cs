using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : Transporte
    {
        private bool esInternacional;

        public Avion(ECombustible combustible,ETipo tipo, int cantidadMaximaPasajeros, bool esInternacional):base(combustible,tipo,cantidadMaximaPasajeros)
        {
            this.esInternacional = esInternacional;
        }

        public bool EsInternacional
        {
            get { return this.esInternacional; }
            set { this.esInternacional = value; }
        }

        public override void Frenar()
        {
            Console.WriteLine("Baja revoluciones de turbinas y va perdiendo vuelo");
        }


    }
}
