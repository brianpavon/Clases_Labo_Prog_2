﻿using EntidadesPizzeria;
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
    public partial class frmPedidos : Form
    {
        public Pedido pedido;
        private Cliente cliente;
        public frmPedidos()
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            //this.pedido = cliente;//aca creo un nuevo pedido
            this.pedido.horaIngreso = DateTime.Now;
            this.pedido.envia = chkbEnvio.Checked;//si tilda se agrega true en el atributo envia
        }

        private void btnAgregarPizza_Click(object sender, EventArgs e)
        {
            if (this.pedido.pizzas + new Pizza(this.cmbCantPizzas)) ;//le paso los parametros al constructor
            {
                cargarPizzas();//este metodo va a mostrar en el listbox de pedidos todo los pedidos
            }
        }
        private void cargarPizzas()
        {
            this.listpizzas.Items.Clear();
            foreach
        }
    }
}
