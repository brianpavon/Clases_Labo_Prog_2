using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Entidades
{
    public abstract class Persona //con la palabra abstract, hacemos una clase "sellada",con esto no se puede instanciar en otro lugar
    {
        public string Nombre { get; set; }//esta propiedad es como un atributo publico, hace lo mismo que
                                          //la propiedad de abajo, pero esta escrito mas simple
        protected string apellido;//protected permite que las clases hijas tambien usen este atributo
                                  //se maneja para la clase padre y derivadas, pero private para las clases que lo instancien


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string MostrarNombre()
        {
            return this.Nombre + " " + this.apellido;
        }

        //constructor
        public Persona(string nombre):this()
        {
            this.Nombre = nombre;
        }
        public Persona()
        {
            this.Nombre = "Sin nombre";
            this.apellido = "Sin apellido";
        }

        
    }
}
