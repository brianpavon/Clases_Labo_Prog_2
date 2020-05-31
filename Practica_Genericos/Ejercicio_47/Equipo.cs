using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre,DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
            set
            {
                this.fechaCreacion = value;
            }
        }

        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            if(!(equipoA is null && equipoB is null))
            {
                return (equipoA.nombre == equipoB.nombre && equipoA.fechaCreacion == equipoB.fechaCreacion);
            }
            return false;
        }

        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }

        public virtual string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} fundado el {this.fechaCreacion}");

            return sb.ToString();

        }
    }
}
