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
using System.Threading;
using System.IO;

namespace PracticaHilos
{
    public partial class Practica : Form
    {
        SqlConnection miConexion;
        
        List<string> mensajes;
        Thread hilo;
        public Practica()
        {
            InitializeComponent();
            mensajes = new List<string>();
            miConexion = new SqlConnection();
            
            miConexion.ConnectionString = @"Data Source = LAPTOP-Q1OJ1113\SQLEXPRESS01 ; Initial Catalog = Argentina; Trusted_Connection = True";
            hilo = new Thread(new ParameterizedThreadStart (CarmbiarMensaje));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CargarConexion();
            //hilo.Start(this.statusStrip);
        }

        private void CargarConexion()
        {
            try
            {
                SqlCommand comando = new SqlCommand();//hace la consulta a la base de datos
                miConexion.Open();
                comando.Connection = miConexion;
                comando.CommandText = "select * from Hilos";
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())//si tiene info da true
                {
                    mensajes.Add(reader[1].ToString());
                }
                //hilo.Start(this.statusStrip);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(miConexion.State != ConnectionState.Closed)
                miConexion.Close();
            }
        }

        private void MostrarMensaje(int indice)
        {
            //StringBuilder sb = new StringBuilder();
            /*foreach (string item in this.mensajes)
            {
                //sb.AppendLine(item.ToString());
                this.toolStripStatusLabel1.Text = item.ToString();
            }
            return sb.ToString();*/

            //for (int i = 0; i < mensajes.Count; i++)
            //{
         this.toolStripStatusLabel1.Text = mensajes[indice-1].ToString();
              
            //}
        }
        
        private void CarmbiarMensaje(object obj)
        {
            //ToolStripLabel modificarLabel = (ToolStripLabel)obj;
            
            StatusStrip modificarStrip = (StatusStrip)obj;
            int contador = 0;
            
            while (true)
            {
                
                //if (contador > 4)
                    //contador = 0;
                /*((MethodInvoker)delegate ()
                {
                    modificarLabel.Text = this.MostrarMensaje();
                });*/
                
                if (modificarStrip.InvokeRequired)
                {
                    modificarStrip.BeginInvoke((MethodInvoker)delegate ()
                   {

                       //this.toolStripStatusLabel1.Text = mensajes.ToString();
                       this.MostrarMensaje(contador);
                       //this.MostrarMensaje();
                       //this.toolStripStatusLabel1.Text = this.MostrarMensaje();
                       //modificarStrip.Items.Add(this.MostrarMensaje());
                       //modificarStrip.Items.Add(mensajes.ToString());
                       //modificarStrip.Text= this.MostrarMensaje();
                   });
                }
                else
                {
                    //modificarStrip.Text = this.MostrarMensaje();
                    this.MostrarMensaje(contador);
                    //this.MostrarMensaje();
                }
                contador++;
                if (contador == 6)
                {
                    contador = 1;
                }
                Thread.Sleep(5000);
            }
            
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (!hilo.IsAlive)
            {
                hilo.Start(this.statusStrip);
                //hilo.Start(this.toolStripStatusLabel1);
            }
            
        }

        private void Practica_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hilo.IsAlive)
            {
                hilo.Abort();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + @"\archivo.txt";
            using(StreamWriter writer = new StreamWriter(path))
            {
                foreach (var item in this.mensajes)
                {
                    writer.WriteLine(item.ToString());
                }
                //writer.WriteLine(this.mensajes.ToString());
            }
            MessageBox.Show("Listo", "Cerrar", MessageBoxButtons.OK);
            this.Close();
            
        }
    }
}
