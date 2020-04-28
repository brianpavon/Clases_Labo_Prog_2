using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Automovil
    {
        protected short cantidadRuedas;
        protected short cantPuertas;
        protected short cantidadMarchas;
        protected Colores color;
        protected int capacidadPasajeros;
        public short CantidadRuedas
        {
            get { return cantidadRuedas; }
            set { cantidadRuedas = value; }

        }
        public short CantPuertas
        {
            get { return cantPuertas; }
            set { cantPuertas = value; }
        }
        public short CantidadMarchas
        {
            get { return cantidadMarchas; }
            set { cantidadMarchas = value; }
        }
        public Colores Color
        {
            get { return color; }
            set { color = value; }
        }
        public int CantidadPasajeros
        {
            get { return capacidadPasajeros; }
            set { capacidadPasajeros = value; }
        }
    }
}
