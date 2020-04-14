using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validamos primero el dni
            double dni;
            
            if(Double.TryParse(this.txtDNI.Text, out dni))
            {
                Usuario persona = new Usuario(this.txtNombre.Text, this.txtApellido.Text, dni);
                //this.txtNombre.Text = "Hola";
                this.lblSalida.Text = persona.Mostrar();
            }
            else 
            {
                //MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) == DialogResult.OK;//esta clase muestra un mensaje por pantalla
                MessageBox.Show("Ocurrio un error con el DNI");
            }
            
        }
    }
}
