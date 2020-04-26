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
        public static List<Pedido> pedidos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {

            frmCliente frmCliente = new frmCliente();
            this.Hide();
            clientes = new List<Cliente>();            
            frmCliente.ShowDialog();
            this.Show();
            if(clientes.Count > 0)
            {
                string datos = Cliente.MostrarDatos(clientes[0]);
                listCliente.Items.Add(datos);
            }                 

        }
       

        private void listCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            if (listCliente.Items.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente o dar un alta","Error",MessageBoxButtons.OK);
            }
            else
            {
                frmPedidos frmPedidos = new frmPedidos();
                pedidos = new List<Pedido>();
                frmPedidos.ShowDialog();                
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar el programa?", "Cierre de la Pizzeria", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
    }
}
