using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carreta : Transporte
    {
        private int cantidadCaballos;

        public Carreta(ECombustible combustible, ETipo tipo, int cantidadMaximaPasajeros,int cantidadCaballos):base(combustible,tipo,cantidadMaximaPasajeros)
        {
            this.cantidadCaballos = cantidadCaballos;
        }

        public int CantidadCaballos
        {
            get { return this.cantidadCaballos; }
            set { this.cantidadCaballos = value; }
        }

        public override void Frenar()//con override implemento el metodo que heredo de la clase padre
        {
            Console.WriteLine("Calman los caballos y de a poco frena");
        }

    }
}
