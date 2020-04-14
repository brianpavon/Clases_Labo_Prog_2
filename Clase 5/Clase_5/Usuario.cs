using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
    public class Usuario
    {
        string nombre;
        string apellido;
        double dni;

        public Usuario(string nombre,string apellido,double dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Apellido: "+ apellido);
            sb.AppendLine("Nombre: " + nombre);
            sb.AppendLine("DNI: {0}" + dni);
            return sb.ToString();
        }


    }
}
