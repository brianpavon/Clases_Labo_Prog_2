using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmHilos
{
    public partial class Form1 : Form
    {
        Thread t; // con esto ejecutamos un nuevo hilo
        public Form1()
        {
            InitializeComponent();
            //t = new Thread(MostrarTiempo);//pide un parametro, y pide que metodo se va a ejecutar en ese hilo
            t = new Thread(new ParameterizedThreadStart(MostrarTiempo)); //para pasar algo adentro
            //en el star le pasamos el parametro, y solo le podemos pasar un metodo
        }


        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MostrarTiempo(object utcObj)//este metodo esta en declarado en el thread
        {
            int utc = -3;
            Label lblAModificar = (Label)utcObj; // es el lbl del form que se paso por parametro
            // le pasamos un utc de la hora, sin importar si es de nuestra maquina u otra
            //este metodo no se va a ejecutar si no hacemos otro hilo...
            //porque siempre se ejecuta el while, y no deja otra cosa
            while (true)
            {
                if (lblAModificar.InvokeRequired)//si necesita invocarse o no entra
                {
                    //accedo de esta manera porque el label esta en otro thread
                    lblAModificar.BeginInvoke((MethodInvoker)delegate ()
                    {
                        //lblMostrar.Text = DateTime.Now.ToString("hh:MM:ss");
                        lblAModificar.Text = DateTime.UtcNow.AddHours(utc).ToString("hh:mm:ss");
                    });//le paso al otro hilo que quiero que se ejectute                  
                    
                }
                else //este else no tiene sentido porque esta en el mismo thread
                {
                    lblAModificar.Text = DateTime.Now.ToString("hh:mm:ss");
                    //Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
            }

        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!t.IsAlive) // el hilo corre una sola vez por eso le pongo esta validacion
            {    //MostrarTiempo(); esto va declarado en el constructor junto con la declaracion del nuevo hilo
                //t.Start();//le decimos al hilo que empiece
                //t.Start(-3);//en el start le pasamos el objeto que necesita el metodo que pasamos al inicializar t
             t.Start(this.lblMostrar);//le paso el lbl directamente para que lo modifique
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cuando este cerrando cierro el hilo si estuviera abierto
            // sino lo cierro se sigue ejecutando..
            if (t.IsAlive)
            {
                t.Abort();
            }
        }

    }
        
    
}
