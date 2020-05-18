using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    //para crear una excepcion para este proyecto
    class EdadAlumnoException : Exception //tiene que heredad la clase excepcion
    {
		private int edad;

		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}
		public EdadAlumnoException(int Edad,string Mensaje) : base(Mensaje)
		{
			this.edad = Edad;
		}

	}
}
