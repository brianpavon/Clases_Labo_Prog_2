using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Ejercicio_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;//aca le puedo agregar adentro de este formulario otros formularios

            //Form2 miFormulario = new Form2();//aca instancio el formulario 2 para poder usar, lo hago en el formulario que lo va a contener

            //miFormulario.MdiParent = this;//le digo al form2 cual es su padre, en este caso es el form1
            //miFormulario.Show();//muestro el formulario dentro del otro...
            
        }
    }
}
