using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Moto
    {
        protected short cantidadRuedas;
        protected short cantPuertas;        
        protected Colores color;
        protected short cilindrada;
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
        public Colores Color
        {
            get { return color; }
            set { color = value; }
        }
        public short Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }
    }
}
