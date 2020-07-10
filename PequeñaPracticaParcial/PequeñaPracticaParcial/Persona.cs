using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PequeñaPracticaParcial
{
    public class Persona
    {
		private long dni;
		private int temperatura;
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}


		public int Temperatura
		{
			get 
			{ 
				return temperatura; 
			}
			set 
			{ 
				temperatura = value; 
			}
		}




		public long DNI
		{
			get { return dni; }
			set { dni = value; }
		}

		public Persona(string nombre, long dni)
		{
			this.nombre = nombre;
			this.dni = dni;
			
		}




	}
}
