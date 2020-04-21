namespace pizzeriaFormulario
{
    partial class FrmPrincipal
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
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.listCliente = new System.Windows.Forms.ListBox();
            this.listPedidos = new System.Windows.Forms.ListBox();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(36, 318);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(136, 23);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // listCliente
            // 
            this.listCliente.FormattingEnabled = true;
            this.listCliente.ItemHeight = 16;
            this.listCliente.Location = new System.Drawing.Point(36, 80);
            this.listCliente.Name = "listCliente";
            this.listCliente.Size = new System.Drawing.Size(120, 212);
            this.listCliente.TabIndex = 1;
            this.listCliente.SelectedIndexChanged += new System.EventHandler(this.listCliente_SelectedIndexChanged);
            // 
            // listPedidos
            // 
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.ItemHeight = 16;
            this.listPedidos.Location = new System.Drawing.Point(210, 113);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(120, 228);
            this.listPedidos.TabIndex = 2;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Location = new System.Drawing.Point(236, 80);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoPedido.TabIndex = 3;
            this.btnNuevoPedido.Text = "Nuevo Pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.listCliente);
            this.Controls.Add(this.btnNuevoCliente);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.ListBox listCliente;
        private System.Windows.Forms.ListBox listPedidos;
        private System.Windows.Forms.Button btnNuevoPedido;
    }
}