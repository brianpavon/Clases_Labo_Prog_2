using System;
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
    //declaramos aca el delegado
    public delegate void CargarMensaje(string palabra);
    public partial class FrmEnvia : Form
    {
        //una vez que tenemos el delegado creamos el evento
        //cuando tengo el evento puedo lanzarlo
        public event CargarMensaje EnviaMensaje;
        public FrmEnvia()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //aca le decimos que lance un evento, en este caso cuando el text box tenga un mensaje sino no
            if (txtEnvia.Text != string.Empty)
            {   //aca uso el delegado que maneja el evento
                //envioEvento(); osea es lo que voy a lanzar
                //EnviaMensaje(txtEnvia.Text);esta linea es igual a la de abajo...con cualquiera lo invoco
                if(!(EnviaMensaje.GetInvocationList() is null))// aca dice que si hay una lista que lo invoco realice el evento
                EnviaMensaje.Invoke(txtEnvia.Text);
            }
                
                

        }
    }
}
