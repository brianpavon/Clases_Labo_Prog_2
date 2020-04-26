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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.listCliente = new System.Windows.Forms.ListBox();
            this.listPedidos = new System.Windows.Forms.ListBox();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(117, 92);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(136, 55);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // listCliente
            // 
            this.listCliente.FormattingEnabled = true;
            this.listCliente.ItemHeight = 16;
            this.listCliente.Location = new System.Drawing.Point(2, 162);
            this.listCliente.Name = "listCliente";
            this.listCliente.Size = new System.Drawing.Size(399, 308);
            this.listCliente.TabIndex = 1;
            this.listCliente.SelectedIndexChanged += new System.EventHandler(this.listCliente_SelectedIndexChanged);
            // 
            // listPedidos
            // 
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.ItemHeight = 16;
            this.listPedidos.Location = new System.Drawing.Point(433, 162);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(401, 308);
            this.listPedidos.TabIndex = 3;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Location = new System.Drawing.Point(570, 92);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(131, 55);
            this.btnNuevoPedido.TabIndex = 2;
            this.btnNuevoPedido.Text = "Nuevo Pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(712, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 50);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 482);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.listCliente);
            this.Controls.Add(this.btnNuevoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzeria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.ListBox listCliente;
        private System.Windows.Forms.ListBox listPedidos;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnCerrar;
    }
}