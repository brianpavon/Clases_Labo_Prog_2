using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    //esto es un enumerado, donde fuerzo al usuario que elija ciertas opciones
    public enum Materias//lo hago afuera de la clase para que se pueda usar en otas las clases
    {
        //defino las materias
        Matematica = 10,//puedo darle un nro de codigo o ID, los de abajo, sino los defino van ascendiendo
        Ingles,
        Programacion2,
        Laboratorio2
    }
    /*si quisisera cargar un enumerado en un combobox
     * cm_Combo.DataSources = Enum.GetNames(typeof (Materias))
     * y lo escribo en el load
    */
    public class Aula
    {
        
        public List<Alumno> alumnos; //creo una lista donde se cargaran la lista de alumnos
        //public List<Alumno> presentes;


        //VAMOS A DEFINIR LA MATERIA
        //private string materia;
        //le paso un enumerador mejor
        private Materias materia;

        public Aula(Materias materia)
        {
            this.materia = materia;

            alumnos = new List<Alumno>(); // inicio la lista cargandole elementos
            alumnos.Add(new Alumno("Juan", "Gonzalez", 20, 13232));
            alumnos.Add(new Alumno("Pepe", "Peposo", 10, 201));
            alumnos.Add(new Alumno("Mariano", "Luis", 12, 563));
            alumnos.Add(new Alumno("Pedro", "Martinez", 15, 3565));
        }

        //creo una propiedad
        public Alumno this[int indice]//al this va la lista y en el indice la posicion que le paso
        {
            get 
            {
                //lo que hace es devolver el alumno en esa posicion
                return this.alumnos[indice];
            }
            set
            {
                this.alumnos[indice] = value;//con esto podria cargar
            }
        }




    }
}
