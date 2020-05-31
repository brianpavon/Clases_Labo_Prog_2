using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio_47
{
    public class Torneo<T> where T : Equipo
    {
       
        private List<T> listaEquipos;        
        private string nombre;
        

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            listaEquipos = new List<T>();
        }

        public List<T> ListaEquipos
        {
            get
            {
                return this.listaEquipos;
            }
            set
            {
                this.listaEquipos = value;
            }

        }

        public static bool operator ==(Torneo<T> torneo,T equipoA)
        {
            bool retorno = false;
            foreach (T aux in torneo.listaEquipos)
            {
                if (aux == equipoA)
                    retorno = true;
            }
            return retorno;
        } 

        public static bool operator !=(Torneo<T> torneo,T equipoA)
        {
            bool retorno = false;
            foreach (T aux in torneo.listaEquipos)
            {
                if (aux != equipoA)
                    retorno = true;
            }
            return retorno;
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipoA)
        {
            //Torneo<T> torneoAux = torneo;

            //if(torneo.listaEquipos.Count == 0)
            //{
            //    torneoAux.listaEquipos.Add(equipoA);
            //}
            //else if(torneo.listaEquipos.Count > 0)
            //{
            //    foreach (T aux in torneo.listaEquipos)
            //    {
            //        if (aux != equipoA)
            //        {
            //            //torneoAux.listaEquipos.Add(equipoA);
            //            torneoAux.listaEquipos.Add(equipoA);
            //            break;
            //        }
            //    }
            //}
            bool repetido = false;
            foreach (T aux in torneo.listaEquipos)
            {
                if (aux == equipoA)
                    repetido = true;
            }
            if(repetido is false)
            {
                torneo.listaEquipos.Add(equipoA);
            }
            
            return torneo;            
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El torneo { this.nombre} tiene {this.listaEquipos.Count.ToString()} equipos");
            foreach (Equipo aux in this.listaEquipos)
            {
                sb.AppendLine(aux.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularPartido(T equipoA, T equipoB)
        {
            Random resultado = new Random(DateTime.Now.Millisecond);
            Random resultadoDos = new Random(DateTime.Now.Millisecond + 2000);            
            int resultadoA = resultado.Next(0, 10);
            int resultadoB = resultadoDos.Next(0, 10);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{equipoA.Nombre} {resultadoA.ToString()}-----{equipoB.Nombre} {resultadoB.ToString()}");

            return sb.ToString();
        }

        public string JugarPartido
        {
            get
            {
                Random seleccion = new Random(DateTime.Now.Millisecond);
                Random seleccionDos = new Random(DateTime.Now.Millisecond + 1000);
                int index = seleccion.Next(0, listaEquipos.Count-1);
                int indexDos = seleccionDos.Next(0, listaEquipos.Count-1);
                
                T equipoA = listaEquipos.ElementAt(index);
                T equipoB = listaEquipos.ElementAt(indexDos);
                return CalcularPartido(equipoA,equipoB);
            }
        }


    }
}
