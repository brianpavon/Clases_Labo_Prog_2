using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(string origen,Franja miFranja,float duracion, string destino):base(duracion,origen,destino)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada):this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"La franja horaria de la llamada es {this.franjaHoraria}");
            sb.AppendLine($"El costo fue de {this.CostoLlamada}");

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = 0.99F * this.duracion;
                    break;
                case Franja.Franja_2:
                    retorno = 1.25F * this.duracion;
                    break;
                case Franja.Franja_3:
                    retorno = 0.66F * this.duracion;
                    break;

            }
            return retorno;
        }

        public override bool Equals(object obj)
        {         
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
