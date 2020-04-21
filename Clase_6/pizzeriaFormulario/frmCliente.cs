using EntidadesPizzeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzeriaFormulario
{
    public partial class frmCliente : Form
    {
        public static List<Cliente> clientes;
        public frmCliente()
        {
            InitializeComponent();
        }
        static frmCliente()
        {
            frmCliente.clientes = new List<Cliente>();
        }
        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNombreCliente.Text, txtApellido.Text, txtDomicilio.Text);
            frmCliente.clientes.Add(cliente);//agrega el cliente a la lista

        }
    }
}
