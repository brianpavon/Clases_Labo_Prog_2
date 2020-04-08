using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Clase_4
{
    class Producto
    {
        /*Debemos realizar la carga de 5(cinco) productos de prevención de contagio,
                de cada una debo obtener los siguientes datos:
                el tipo (validar "barbijo" , "jabón" o "alcohol") ,
                el precio (validar entre 100 y 300),
                la cantidad de unidades (no puede ser 0 o negativo y no debe superar las 1000 unidades),
                la Marca
                y el fabricante
          */
        public string tipo;
        public float precio;
        public int cantUnidades;
        public string marca;
        public string fabricante;

        
        public Producto(string tipo,float precio,int cantUnidades,string marca,string fabricante)
        {
            this.tipo = tipo;
            this.precio = precio;
            this.cantUnidades = cantUnidades;
            this.marca = marca;
            this.fabricante = fabricante;
        }
        //VAMOS A HACER UNA SOBRECARGA DE ESTE CONSTRUCTOR, SOBRECARGA SIGNIFICA SINO LE PASO PARAMETROS, CARGA LO QUE ESTA POR DEFECTO
        public Producto()
        {
            this.tipo = "TIPO DEFECTO";
            this.precio = 100;
            this.cantUnidades = 1;
            this.marca = "MARCA MARCA";
            this.fabricante = "FABRICANTE";
        }

        //CONSTRUCTOR CON ALGUNOS PARAMETROS Y EL :THIS LLAMA AL CONSTRUCTOR "HARDCODEADO" Y CARGA LOS VALORES QUE TIENE ESE CONSTRUCTOR
        public Producto(string tipo, float precio, int cantUnidades):this() //con : llamo al constructor por defecto,y cargo los valores que no se piden para cargar
        {
            this.tipo = tipo;
            this.precio = precio;
            this.cantUnidades = cantUnidades;
            
        }

        /*sobrecarga tiene el mismo nombre pero tiene diferentes paramentros,
         *para constructor, se diferencia por el tipo de parametros, o por los parametros
         * para metodos, es lo mismo, difiere la cantidad o el tipo de parametros, el retorno no afecta en nada...
         *  para ser diferentes tienen que modificar el tipo o cantidad de parametros
         *  a los metodos, si los podes llamar dentro de otro
        */
        
        public void Ingresar()
        {
            this.tipo = "TIPO DEFECTO";
            this.precio = 100;
            this.cantUnidades = 1;
            this.marca = "MARCA MARCA";
            this.fabricante = "FABRICANTE";

        }

        //comparar 2 productos
        public static bool operator == (Producto producto1, Producto producto2)
        {
            return producto1.tipo == producto2.tipo && producto1.marca == producto2.marca && producto1.marca && producto1.fabricante==producto2.fabricante;

        }

        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);

        }


        //si queremos castear de un estante a producto
         public static implicit operator Estante(Producto producto)
        {
            Estante estante = new Estante(1);
            if (estante + producto)
                return estante;
            return null;
        }
        //conversion implicit y explicit sirve para pasar de un tipo de datos a otros...
        //IMPLICITO, no hay perdida de datos, 
        //castear Producto producto1 = "Barbijo"; barbijo es el strin tipo
        public static implicit operator Producto(string tipo)//especie de puente, para castear,
        {
            Producto aux = new Producto();
            aux.tipo = tipo;
            return aux;
        }

        //EXPLICITO, hay perdida de datos
        public static explicit operator string(Producto prod)
        {
            string aux = " tipo:" + prod.tipo;
            aux += " marca:" + prod.marca;
            aux += " fabricante:" + prod.fabricante;

            return aux;
        }
    }
}
