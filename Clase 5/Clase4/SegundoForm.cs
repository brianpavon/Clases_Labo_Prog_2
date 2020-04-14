using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Clase4
{
    public class SegundoForm : Form
    {
        private Button button1;

        //frmPrimero() ESTE CONSTRUCTOR SE EJECUTA SOLO DE TODAS MANERAS
        //{
            //InitializeComponent();
        //}
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.AccessibleName = "btnAceptar";
            this.button1.Location = new System.Drawing.Point(87, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SegundoForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.Name = "SegundoForm";
            this.ResumeLayout(false);

        }
    }
}
