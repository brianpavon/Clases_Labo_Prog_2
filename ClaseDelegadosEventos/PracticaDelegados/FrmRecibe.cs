using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDelegados
{
    public partial class FrmRecibe : Form
    {
        public FrmRecibe()
        {
            InitializeComponent();
        }

        //creo un metodo publico que recibe un texto, asigna al label lo que le llego por parametro
        //de esta manera linkeo el manejador del mostrar mensaje.
        public void MostrarMensaje(string texto)
        {
            this.lblRecibe.Text = texto;
        }

        /*private void btnUno_Click(object sender, EventArgs e)
        {
            this.btnUno.Click -= btnUno_Click;
            MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            this.btnUno.Click += btnDos_Click;
        }*/

        /*private void btnDos_Click(object sender, EventArgs e)
        {
            this.btnDos.Click -= btnDos_Click;
            MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            this.btnDos.Click += btnTres_Click;
        }
        private void btnTres_Click(object sender, EventArgs e)
        {
            this.btnTres.Click -= btnTres_Click;
            MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            this.btnTres.Click += btnCuatro_Click;
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            this.btnCuatro.Click -= btnCuatro_Click;
            MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            this.btnCuatro.Click += btnUno_Click;
        }*/
        private void btnUno_Click(object sender, EventArgs e)
        {
            this.btnUno.Click -= btnUno_Click;
            MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            //this.btnUno.Click += btnDos_Click;
            this.btnDos.Click += btnDos_Click;
        }
        private void btnDos_Click(object sender, EventArgs e)
        {
            this.btnDos.Click -= btnDos_Click;
            MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            //this.btnDos.Click += btnTres_Click;
            this.btnTres.Click += btnTres_Click;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            this.btnTres.Click -= btnTres_Click;
            MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            //this.btnTres.Click += btnCuatro_Click;
            this.btnCuatro.Click += btnCuatro_Click;
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            this.btnCuatro.Click -= btnCuatro_Click;
            MessageBox.Show("Soy el boton " + ((Button)sender).Text);
            //this.btnCuatro.Click += btnUno_Click;
            this.btnUno.Click += btnUno_Click;
        }

        /*private void MuestroMensaje(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnUno":
                    btnUno.Click -= MuestroMensaje;
                    btnDos.Click += MuestroMensaje;
                    break;
                case "btnDos":
                    btnDos.Click -= MuestroMensaje;
                    btnTres.Click += MuestroMensaje;
                    break;
                case "btnTres":
                    btnTres.Click -= MuestroMensaje;
                    btnCuatro.Click += MuestroMensaje;
                    break;
                case "btnCuatro":
                    btnCuatro.Click -= MuestroMensaje;
                    btnUno.Click += MuestroMensaje;
                    break;
            }
        }*/


    }
}
