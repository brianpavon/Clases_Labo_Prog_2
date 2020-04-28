using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Entidades
{
    internal class Profesor : Staff //si escribo asi digo que la clase profesor hereda los atributos de Persona
    {
        //su clase padre es Staff que a su vez hereda a Persona
        public Profesor(string nombre):base(nombre)
        {

        }
        int codMateria;

        public int CodigoMateria
        {
            get 
            {
                return this.codMateria;
            }
            set
            {
                this.codMateria = value;
            }
        }

        public new string MostrarNombre()//si ponemos new en un metodo con el mismo nombre, se va la advertencia
        {
            return "Nombre de Profesor";
        }

        public string ModificarNombre(Profesor p, string nombre)
        {
            p.apellido = nombre; // como estoy dentro de una clase derivada puedo ver atributos privados
            return p.Nombre;
        }
    }
}
