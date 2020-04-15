using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPizzeria
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;


        private Cliente()
        {
            this.nombre = "SIN NOMBRE";
            this.apellido = "SIN APELLIDO";
            this.domicilio = "SIN DOMICILIO";
        }

        public Cliente(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente(string nombre,string domicilio):this(nombre)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
        }

        public Cliente(string nombre,string apellido,string domicilio):this(nombre,domicilio)
        {
            this.apellido = apellido;
        }




    }
}
