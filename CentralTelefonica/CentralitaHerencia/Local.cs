using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public Local(Llamada llamada, float costo): this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {

            
        }

        public Local(string origen,float duracion,string destino,float costo):base(duracion,origen,destino)
        {
            this.costo = costo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"El costo de la llamada fue {this.costo}");
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float retorno;
            return retorno = this.costo * this.duracion;
        }

    }
}
