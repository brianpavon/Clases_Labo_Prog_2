using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class InstrumentoMusical //abstract, esta clase me sirve de molde para otras clases, pero no se van a crear instrumentos musicales, solo los de cada tipo
    {
        //protected int precio;
        //protected string descNombre;
        //protected string marca;
        //protected int codigo;
        //protected List<string> listaNombres;//con las listas en algun momento tengo que inicializar esto, porque es un objeto
        //protected static List<string> listaStatic;//este static conviene declarar en un constructor estatico

        //PRIMERO HACEMOS TODOS LOS CONSTRUCTORES
        //public InstrumentoMusical()
        //{
        //    //este constructor por lo general se lo usa para iniciar listas, arrays o atributos que sean objetos
        //    //las list no es necesario preguntar si es null, a la primera,porque solo se empieza a llenar cuando se cargam
        //    //items.
        //    //en arrays si conviene preguntar por is null
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

        //public InstrumentoMusical(int precio,string descNombre,string marca, int codigo):this()
        //{
        //    this.precio = precio;
        //    this.descNombre = descNombre;
        //    this.marca = marca;
        //    this.codigo = codigo;
        //}

        //si tuviera una lista estatica conviene inicializarla conviene en un constructor estatico
        //los constructores estaticos se inician primero que los de instancia

        //static InstrumentoMusical()
        //{
        //    listaStatic = new List<string>();
        //}

        //DECLARO PROPIEDADES
        //public int Precio//le podria poner cualquier nombre  lo que importa es lo que hace en el cuerpo, que obtiene y setea
        //{
        //    get { return this.precio; }
        //    set { this.precio = value; }
        //}

        //public string DescNombre
        //{
        //    get { return this.descNombre; }
        //    set { this.descNombre = value; }
        //}

        //public string Marca
        //{
        //    get { return this.marca; }
        //    set { this.marca = value; }
        //}

        //public int Codigo
        //{
        //    get { return this.codigo; }
        //    set { this.codigo = value; }
        //}

        //LOS INDEXADORES SE USAN DECLARANDO public string this[int index]el index es para indicar de que lugar quiero obtener o cargar

        protected int precio;
        protected string marca;
        protected bool fabricadoEnArgentina;
        protected string descripcion;

        public InstrumentoMusical()
        {
            this.descripcion = "Sin descripcion";
        }

        public InstrumentoMusical(int precio,string marca,bool fabricadoEnArgentina):this()
        {
            this.precio = precio;
            this.marca = marca;
            this.fabricadoEnArgentina = fabricadoEnArgentina;

        }

        public abstract string AfinarInstrumento();//con esto hago que cada clase que hereda a esta, implemente este metodo
        //cada clase con override implementara este metodo

        //una propiedad abstracta se define asi:

        //public abstract string IncluyeEnLaPromo { get; }//y si pongo get o set exijo que las clases heredadas, los definan
       

    }
}
