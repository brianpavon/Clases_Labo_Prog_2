using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
    public class Llamada
    {
        
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La duracion de la llamada fue {this.duracion} minutos, llamo desde {this.nroOrigen} hacia {this.nroDestino}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
        {
            int retorno;

            if(llamadaUno.duracion == llamadaDos.duracion)
            {
                retorno = 0;
            }
            else if(llamadaUno.duracion > llamadaDos.duracion)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }
            return retorno;
        }
    }
}
