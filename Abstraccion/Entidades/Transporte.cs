using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipo
    {
        Aereo,
        Martimo,
        Terrestre
    }
    public enum ECombustible
    {
        Nafta,
        Diesel,
        TraccionSangre
    }
    public abstract class Transporte //creo esta clase abstracta
    {
        private ETipo tipo;
        private ECombustible combustible;
        int cantidadMaximaPasajeros;

        public Transporte(ECombustible combustible, ETipo tipo, int cantidadMaximaPasajeros)
        {
            this.combustible = combustible;
            this.tipo = tipo;
            this.cantidadMaximaPasajeros = cantidadMaximaPasajeros;
        }
        public ETipo Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }

        }      


        public ECombustible Combustible
        {
            get { return this.combustible; }
            set { this.combustible = value; }
        }

        public int CantidadMaximaPasajeros
        {
            get { return this.cantidadMaximaPasajeros; }
            set { this.cantidadMaximaPasajeros = value; }
        }

        public virtual string Mostrar()//con la palabra virtual hacemos que las clases hijas puedan modificar este metodo
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo Transporte: {this.tipo}");
            sb.AppendLine($"Cantidad pasajeros: {this.cantidadMaximaPasajeros}");
            sb.AppendLine($"Tipo combustible: {this.combustible}");
            return sb.ToString();
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancar");
        }

        public abstract void Frenar();//si le pongo abstract dejo que las clases hijas definan ese metodo,e implementarlo
    }
}
