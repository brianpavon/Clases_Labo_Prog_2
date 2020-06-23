namespace PracticaDelegados
{
    partial class FrmPrincipal
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
            this.btnEnvia = new System.Windows.Forms.Button();
            this.btnRecibe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnvia
            // 
            this.btnEnvia.Location = new System.Drawing.Point(76, 43);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(124, 48);
            this.btnEnvia.TabIndex = 0;
            this.btnEnvia.Text = "Form Envia";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // btnRecibe
            // 
            this.btnRecibe.Location = new System.Drawing.Point(76, 141);
            this.btnRecibe.Name = "btnRecibe";
            this.btnRecibe.Size = new System.Drawing.Size(124, 46);
            this.btnRecibe.TabIndex = 1;
            this.btnRecibe.Text = "Form Recibe";
            this.btnRecibe.UseVisualStyleBackColor = true;
            this.btnRecibe.Click += new System.EventHandler(this.btnRecibe_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 257);
            this.Controls.Add(this.btnRecibe);
            this.Controls.Add(this.btnEnvia);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.Button btnRecibe;
    }
}

