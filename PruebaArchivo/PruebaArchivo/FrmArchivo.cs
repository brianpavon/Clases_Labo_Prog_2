using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaArchivo
{
    public partial class FrmArchivo : Form
    {
        public FrmArchivo()
        {
            InitializeComponent();
            string path = @"C: \Users\brian\OneDrive\Imágenes\archivo.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string linea;
                StringBuilder sb = new StringBuilder();
                while ((linea = sr.ReadLine()) != null)
                {
                    sb.AppendLine(linea);
                }
                this.rchLista.Text = sb.ToString();
                this.lblConfirma.Text = "Leido";
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string path = @"C: \Users\brian\OneDrive\Imágenes\MiArchivo.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(this.rchLista.Text);           
                
            }
            this.lblConfirma.Text = "Listo";
            //MessageBox.Show("Gracias vuelva pronto");
            //this.Close();
        }

        private void rchLista_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
