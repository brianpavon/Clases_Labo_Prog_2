using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanacia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanacia(TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return this.CalcularGanacia(TipoLlamada.Todas);
            }
        }
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanacia(TipoLlamada tipo)
        {
            float retorno = 0;
            foreach (Llamada aux in listaDeLlamadas)
            {
                if(aux is Local && tipo == TipoLlamada.Local)
                {
                    retorno += ((Local)aux).CostoLlamada;
                }
                else if(aux is Provincial && tipo == TipoLlamada.Provincial)
                {
                    retorno += ((Provincial)aux).CostoLlamada;
                }
                else if(tipo == TipoLlamada.Todas)
                {
                    if(aux is Local)
                    {
                        retorno += ((Local)aux).CostoLlamada;
                    }
                    else
                    {
                        retorno += ((Provincial)aux).CostoLlamada;
                    }
                }

            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {this.GananciaPorTotal}");
            sb.AppendLine($"Ganancia por llamados locales: {this.GananciaPorLocal}");
            sb.AppendLine($"Ganancia por llamados provinciales: {this.GananciaPorProvincial}");
            sb.AppendLine("LISTADO DE LLAMADOS:\n");
            foreach (Llamada aux in listaDeLlamadas)
            {
                sb.AppendLine($"{aux.Mostrar()}");
            }

            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
