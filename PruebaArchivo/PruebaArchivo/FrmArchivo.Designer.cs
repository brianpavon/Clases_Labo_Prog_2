namespace PruebaArchivo
{
    partial class FrmArchivo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rchLista = new System.Windows.Forms.RichTextBox();
            this.lblConfirma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(408, 435);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(211, 56);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rchLista
            // 
            this.rchLista.Location = new System.Drawing.Point(81, 33);
            this.rchLista.Name = "rchLista";
            this.rchLista.Size = new System.Drawing.Size(803, 378);
            this.rchLista.TabIndex = 1;
            this.rchLista.Text = "";
            this.rchLista.TextChanged += new System.EventHandler(this.rchLista_TextChanged);
            // 
            // lblConfirma
            // 
            this.lblConfirma.AutoSize = true;
            this.lblConfirma.Location = new System.Drawing.Point(323, 435);
            this.lblConfirma.Name = "lblConfirma";
            this.lblConfirma.Size = new System.Drawing.Size(0, 17);
            this.lblConfirma.TabIndex = 2;
            // 
            // FrmArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 526);
            this.Controls.Add(this.lblConfirma);
            this.Controls.Add(this.rchLista);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmArchivo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox rchLista;
        private System.Windows.Forms.Label lblConfirma;
    }
}

