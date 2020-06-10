using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Direcciones
{
    public partial class Form1 : Form
    {
        SqlConnection cl;//esto permite hacer el puente entre la base de datos y .NET
        SqlCommand sm;
        //Dictionary<decimal, string> provincias;
        List<KeyValuePair<decimal, string>> provincias;

        //creo la lista para guardar las localidades de la base de datos
        List<Localidad> localidades;



        public Form1()
        {
            InitializeComponent();
            //cl es un objeto, podemos cargarle valor por constructor
            //cn = new SqlConnection(@"Data Source = "zaraza"; Initial Catalog = Argentina; Integrated Security = True;");
            cl = new SqlConnection();
            //provincias = new Dictionary<decimal, string>();
            provincias = new List<KeyValuePair<decimal, string>>();
            sm = new SqlCommand();//lleva la instruccion a hacer
            //aca vamos a hacer la conexion a la base de datos.
            //consta de 3 partes, servidor, catalogo, como nos vamos a conectar
            cl.ConnectionString = @"Data Source = LAPTOP-Q1OJ1113\SQLEXPRESS01 ; Initial Catalog = Argentina; Integrated Security = True";
            localidades = new List<Localidad>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //no se hace en el load, sino que el formulario llama a un evento    
            

            //va a tratar de conectarse al servidor
            try
            {
                cl.Open();
                
                //tiene una propiedad que es el command connection
                sm.Connection = cl; //le pasamos la conexion que creamos arriba
                //tambien command text, va a la conexion y ejecuta la consulta
                sm.CommandText = "select * from Provincia"; //ponemos como si fuera base de datos
                //otro comando executeReader, se lo tenemos que pasar a un objeto
                //sqldatareader este tiene los datos
                SqlDataReader dr = sm.ExecuteReader();//nos va a devolver una tabla y lo vamos a poder recorrer en .Net
                //mientras que pueda leer la siguiente columna se ejecuta 
                while (dr.Read())
                {
                    //MessageBox.Show(dr[0].ToString());//si ponemos[numero] llamo las columnas
                    //MessageBox.Show(dr[1].ToString());//si ponemos[nombre] llamo como se llama
                    //provincias.Add((decimal)dr[0],dr[1].ToString());

                    //aca cargamos las provincias a la lista, vamos creando nuevos objetos para agregar
                    provincias.Add(new KeyValuePair<decimal, string>(decimal.Parse(dr[0].ToString()), dr[1].ToString()));


                }
                this.CargarDirecciones();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cl.Close();
            }
            //las mostramos en el combobox
            this.cmbProvincia.DataSource = provincias;
            this.CargarDirecciones();
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                localidades.Clear();
                cl.Open();
                sm.Connection = cl;
                //escribo como base de datos, pero casteo a como esta en la base de datos.... y pongo .Key para que me de el id 
                sm.CommandText = "select * from Localidad where idProvincia = "+ ((KeyValuePair<decimal, string>)this.cmbProvincia.SelectedItem).Key;
                //todo los datos estan guardados en key value pair, le ponemos key para que nos de el id
                SqlDataReader dr = sm.ExecuteReader();

                while (dr.Read())
                {

                    //localidades.Add(new Localidad((decimal)dr[0], (decimal)dr[1], dr[2].ToString()));
                    //creamos un objeto localidad usando el constructor y le vamos pasando por parametro
                    localidades.Add(new Localidad((decimal)dr[0], (decimal)dr[1], dr[2].ToString()));

                }
                
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                cl.Close();
            }
            //las mostramos en el combobox, primero lo ponemos en null,para que se vaya refrescando

            this.cmbLocalidad.DataSource = null;
            this.cmbLocalidad.DataSource = localidades;
        }

        private void CargarDirecciones()
        {
            //vamor a parametrizar mejor las cosas para cargar

            //lista de parametros, es mas seguro para hacer las query o consulta
            //sm.Parameters.Add(new SqlParameter());
            try
            {
                localidades.Clear();
                cl.Open();
                sm.Connection = cl;
                sm.CommandText = "select * from domicilio";
                
                SqlDataReader dr = sm.ExecuteReader();
                //hacemos un datatable para cargar ahi la tabla de la base de datos

                DataTable dt = new DataTable();
                dt.Load(dr);
                this.dataGridView1.DataSource = dt;
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                cl.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Direccion direccion = new Direccion();
            direccion.Calle = this.txtCalle.Text;
            direccion.Numero = int.Parse(this.txtNumero.Text);
            direccion.Piso = int.Parse(this.txtPiso.Text);
            direccion.Departamento = txtDepartamento.Text;
            direccion.IdLocalidad = ((Localidad)cmbLocalidad.SelectedItem).Id;

            //vamos a abrir una conexion... siempre conviene un try
            try
            {
                localidades.Clear();
                sm.Parameters.Clear();
                cl.Open();
                sm.Connection = cl;
                //si voy a cargar todos los atributos no hace falta aclarar, lo paso como parametros
                sm.CommandText = "insert into [domicilio] (calle, numero, piso, departamento,idLocalidad) Values (@calle, @numero, @piso, @departamento,@idLocalidad)";
                
                //creo los parametros que le paso al command text para que haga el comando en la base de datos
                sm.Parameters.Add(new SqlParameter("calle", direccion.Calle));
                sm.Parameters.Add(new SqlParameter("numero", direccion.Numero));
                sm.Parameters.Add(new SqlParameter("piso", direccion.Piso));
                sm.Parameters.Add(new SqlParameter("departamento", direccion.Departamento));
                sm.Parameters.Add(new SqlParameter("idLocalidad", direccion.IdLocalidad));

                //executenonquery devuelve un entero, se usa para ver si pudo insertar
                //devuelve en nro de columnas afectadas
                int retorno = sm.ExecuteNonQuery();
                if(retorno != 1)
                {
                    MessageBox.Show("No se pudo insertar");
                }
                else
                {
                    MessageBox.Show("Limpiar datos");
                }
            }
            finally
            {
                cl.Close();
            }

        }
    }
}
