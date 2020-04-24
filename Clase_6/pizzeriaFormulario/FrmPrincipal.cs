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
    public partial class FrmPrincipal : Form
    {
        public static List<Cliente> clientes;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {

            frmCliente frmCliente = new frmCliente();
            clientes = new List<Cliente>();
            frmCliente.ShowDialog();
            listCliente.Items.Add(clientes);
            listCliente.SelectedItem.ToString();

        }
       

        private void listCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.listCliente.Show(frmCliente.clientes.ToList());
            //foreach (Cliente aux in clientes)
            //{

            //    listCliente.Items.Add(frmCliente.clientes);
            //}
            //listCliente.Items.Add(clientes);
            
            
        }
    }
}
