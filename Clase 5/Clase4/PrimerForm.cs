using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;//para agregar esto lo hago, en referencias,boton derecho, agregar referencia,ensamblados, framework, system windows form
using System.Drawing;


namespace Clase4
{
    public class PrimerForm : Form//esto lo declaro asi
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PrimerForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "PrimerForm";
            this.Load += new System.EventHandler(this.PrimerForm_Load);
            this.ResumeLayout(false);

        }

        private void PrimerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
