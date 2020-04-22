using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Alumno
    {
        private string nombre;
        private string apellido;        
        private int edad;
        private int legajo;
        private int año;
        private int categoria;

        public Alumno(string nom,string ape,int edad,int leg)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.edad = edad;
            this.legajo = leg;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public static string GetUnnombre(Alumno aux)
        {
            return aux.nombre;
        }

        public void SetNombre(string aux)
        {
            this.nombre = aux;
        }
        //propiedades aparece en la herramientita al abrir una clase
        //el short cut para las propiedades es propfull
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public string Nombre//esto seria una propiedad que une get y set y depende de donde se use setea u obtiene un valor
        {
            get 
            { 
                return "El nombre es" + this.nombre;//se puede editar la propieda si separamos asi 
            }
            set //podriamos hacer validaciones, en realidad aplicar los metodos de validacion
            { 
                this.nombre = value; 
            }//el value es el parametro al que se le setearia este atributo
        }

        //Ejemplo de hacer alguna operacion en la propiedad, no es lo mas normal
        public int Edad
        {
            set 
            {
                this.año = DateTime.Now.Year;
                this.categoria = año - value;
                this.edad = value;
            }
        }
    }
}
