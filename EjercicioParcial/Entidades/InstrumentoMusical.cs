using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InstrumentoMusical 
    {
        protected int precio;
        protected string descNombre;
        protected string marca;
        protected int codigo;


        //PRIMERO HACEMOS TODOS LOS CONSTRUCTORES
        //public InstrumentoMusical()
        //{
        //    //este constructor por lo general se lo usa para iniciar listas
        //}
        //Sobrecarga de constructores
        //public InstrumentoMusical(int precio)
        //{
        //    this.precio = precio;
        //}

        //public InstrumentoMusical(int precio, string descNombre):this(precio)
        //{
        //    this.descNombre = descNombre;
        //}

        //public InstrumentoMusical(int precio, string descNombre, string marca):this(precio,descNombre)
        //{
        //    this.marca = marca;
        //}

        //public InstrumentoMusical(int precio,string descNombre,string marca,int codigo):this(precio,descNombre,marca)
        //{
        //    this.marca = marca;
        //}

        //BORRAMOS TODO LO ANTERIOR, Y DEJAMOS EL CONSTRUCTOR CON TOOS LOS PARAMETROS

        public InstrumentoMusical(int precio,string descNombre,string marca, int codigo)
        {
            this.precio = precio;
            this.descNombre = descNombre;
            this.marca = marca;
            this.codigo = codigo;
        }



    }
}
