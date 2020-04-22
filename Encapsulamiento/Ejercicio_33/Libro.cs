using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        public List<string> paginas;


		public Libro()
        {
            paginas = new List<string>();
            CargarPagina();
        }

		private void CargarPagina()
        {
            paginas.Add("Pagina Pancho");//indice 0
            paginas.Add("Pagina Mariano");//indice 1
            paginas.Add("Pagina Manuel");//indice 2

        }

        public string this[int indice]
        {
            get
            {
                //hay que validar que la pagina sea correcta osea > 0
                if(indice > 0 && indice <= paginas.Count)//el .Count dice el total de las paginas
                {
                    return this.paginas[indice - 1];//asi le devuelvo lo correcto
                                                    //para el sistema la clase arranca en 0
                                                    //pero en nuestro caso arranca en 1 las paginas
                }
                return string.Empty;
                
            }
            set
            {
                if(indice >= 0 && paginas.Count >= indice)//(!(this.paginas is null))
                {

                    this.paginas[indice] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }




	}
}
