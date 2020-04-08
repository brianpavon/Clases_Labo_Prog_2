using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_y_explicit
{
    public class Personaje
    {
        private string nombre;
        private string raza;
        private bool esMago;

        public Personaje()
        {

        }

        public static implicit operator Personaje(string nom)
        {
            Personaje aux = new Personaje();
            aux.nombre = nom;

            return Personaje;
        }

        public static implicit operator Personaje(bool hab)
        {
            Personaje aux = new Personaje();
            aux.esMago = hab;

            return aux;
        }

        public static explicit operator string(Personaje persj)
        {

            return "El nombre es: " + persj.nombre;
        }


    }
}
