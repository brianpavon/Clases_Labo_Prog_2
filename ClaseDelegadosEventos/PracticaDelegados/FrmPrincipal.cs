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
    public partial class FrmPrincipal : Form
    {
        FrmRecibe formRecibe;//lo hago asi para tener acceso a algun evento que este en el frmRecibe
        public FrmPrincipal()
        {
            InitializeComponent();
            formRecibe = new FrmRecibe();
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            FrmEnvia formEnvia = new FrmEnvia();
            //formEnvia.EnviaMensaje += new CargarMensaje( FormEnvia_EnviaMensaje); //con el += se le asigna un manejador al evento
            formEnvia.EnviaMensaje += MostrarMensajePrincipal; //tambien lo puedo declarar asi
            formEnvia.EnviaMensaje += formRecibe.MostrarMensaje;//aca uno el segundo formulario... a traves del metodo que tiene definido en su clase
            formEnvia.Show();
            this.btnEnvia.Click += btnEnvia_Click;// aca evito que se haga 2 veces click y me abra de nuevo otro form
        }

        private void MostrarMensajePrincipal(string palabra)
        {
            //throw new NotImplementedException();
            MessageBox.Show(palabra);
        }

        //ESTO LO CREE CUANDO HICE formEnvia.EnviaMensaje +=
        //este manejador si bien es un evento del frmEnvia, solo se accede desde el principal
        private void FormEnvia_EnviaMensaje(string palabra)
        {
            //throw new NotImplementedException();
            MessageBox.Show(palabra);
        }

        private void btnRecibe_Click(object sender, EventArgs e)
        {
            //FrmRecibe formRecibe = new FrmRecibe();
            formRecibe.Show();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

    }
}
