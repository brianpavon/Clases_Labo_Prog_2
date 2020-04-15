using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPizzeria;

namespace pizzeriaFormulario
{
    public partial class Form1 : Form
    {
        //vamos a crear un atributo en esta clase del formulario
        private string informacion = "hola mundo";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = informacion;
        }
    }
}
