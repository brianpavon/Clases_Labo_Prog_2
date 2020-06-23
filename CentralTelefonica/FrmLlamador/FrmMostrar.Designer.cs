namespace FrmLlamador
{
    partial class FrmMostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.btnFacturacionX = new System.Windows.Forms.Button();
            this.btnFacturacionLocal = new System.Windows.Forms.Button();
            this.btnFacturacionProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerarLlamada.FlatAppearance.BorderSize = 2;
            this.btnGenerarLlamada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerarLlamada.Location = new System.Drawing.Point(33, 27);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(240, 50);
            this.btnGenerarLlamada.TabIndex = 0;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = true;
            // 
            // btnFacturacionX
            // 
            this.btnFacturacionX.Location = new System.Drawing.Point(33, 108);
            this.btnFacturacionX.Name = "btnFacturacionX";
            this.btnFacturacionX.Size = new System.Drawing.Size(240, 50);
            this.btnFacturacionX.TabIndex = 1;
            this.btnFacturacionX.Text = "Facturacion Total";
            this.btnFacturacionX.UseVisualStyleBackColor = true;
            // 
            // btnFacturacionLocal
            // 
            this.btnFacturacionLocal.Location = new System.Drawing.Point(33, 191);
            this.btnFacturacionLocal.Name = "btnFacturacionLocal";
            this.btnFacturacionLocal.Size = new System.Drawing.Size(240, 50);
            this.btnFacturacionLocal.TabIndex = 2;
            this.btnFacturacionLocal.Text = "Facturacion Local";
            this.btnFacturacionLocal.UseVisualStyleBackColor = true;
            // 
            // btnFacturacionProvincial
            // 
            this.btnFacturacionProvincial.Location = new System.Drawing.Point(33, 267);
            this.btnFacturacionProvincial.Name = "btnFacturacionProvincial";
            this.btnFacturacionProvincial.Size = new System.Drawing.Size(240, 50);
            this.btnFacturacionProvincial.TabIndex = 3;
            this.btnFacturacionProvincial.Text = "Facturacion Provincial";
            this.btnFacturacionProvincial.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(33, 356);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(240, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 438);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturacionProvincial);
            this.Controls.Add(this.btnFacturacionLocal);
            this.Controls.Add(this.btnFacturacionX);
            this.Controls.Add(this.btnGenerarLlamada);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLlamada;
        private System.Windows.Forms.Button btnFacturacionX;
        private System.Windows.Forms.Button btnFacturacionLocal;
        private System.Windows.Forms.Button btnFacturacionProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}