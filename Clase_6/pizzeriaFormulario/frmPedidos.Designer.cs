namespace pizzeriaFormulario
{
    partial class frmPedidos
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
            this.btnCrearPedido = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblGustos = new System.Windows.Forms.Label();
            this.cmbGustoPizza = new System.Windows.Forms.ComboBox();
            this.lblCoccion = new System.Windows.Forms.Label();
            this.cmbTipoCoccion = new System.Windows.Forms.ComboBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.chkbEnvio = new System.Windows.Forms.CheckBox();
            this.btnAgregarPizza = new System.Windows.Forms.Button();
            this.listPizzas = new System.Windows.Forms.ListBox();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Location = new System.Drawing.Point(395, 354);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(109, 33);
            this.btnCrearPedido.TabIndex = 0;
            this.btnCrearPedido.Text = "Crear Pedido";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(45, 38);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(115, 17);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Ingrese Cantidad";
            // 
            // lblGustos
            // 
            this.lblGustos.AutoSize = true;
            this.lblGustos.Location = new System.Drawing.Point(38, 85);
            this.lblGustos.Name = "lblGustos";
            this.lblGustos.Size = new System.Drawing.Size(122, 17);
            this.lblGustos.TabIndex = 4;
            this.lblGustos.Text = "Cargue los gustos";
            // 
            // cmbGustoPizza
            // 
            this.cmbGustoPizza.FormattingEnabled = true;
            this.cmbGustoPizza.Items.AddRange(new object[] {
            "Muzzarella",
            "Jamon y Morron",
            "Fugazzeta",
            "Cantipalo"});
            this.cmbGustoPizza.Location = new System.Drawing.Point(210, 85);
            this.cmbGustoPizza.Name = "cmbGustoPizza";
            this.cmbGustoPizza.Size = new System.Drawing.Size(121, 24);
            this.cmbGustoPizza.TabIndex = 3;
            // 
            // lblCoccion
            // 
            this.lblCoccion.AutoSize = true;
            this.lblCoccion.Location = new System.Drawing.Point(50, 133);
            this.lblCoccion.Name = "lblCoccion";
            this.lblCoccion.Size = new System.Drawing.Size(110, 17);
            this.lblCoccion.TabIndex = 6;
            this.lblCoccion.Text = "Tipo de Coccion";
            // 
            // cmbTipoCoccion
            // 
            this.cmbTipoCoccion.FormattingEnabled = true;
            this.cmbTipoCoccion.Items.AddRange(new object[] {
            "A la Piedra",
            "Al Molde"});
            this.cmbTipoCoccion.Location = new System.Drawing.Point(210, 126);
            this.cmbTipoCoccion.Name = "cmbTipoCoccion";
            this.cmbTipoCoccion.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoCoccion.TabIndex = 5;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(573, 354);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(101, 33);
            this.btnCancelarPedido.TabIndex = 7;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // chkbEnvio
            // 
            this.chkbEnvio.AutoSize = true;
            this.chkbEnvio.Location = new System.Drawing.Point(395, 292);
            this.chkbEnvio.Name = "chkbEnvio";
            this.chkbEnvio.Size = new System.Drawing.Size(135, 21);
            this.chkbEnvio.TabIndex = 8;
            this.chkbEnvio.Text = "Envia a domicilio";
            this.chkbEnvio.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPizza
            // 
            this.btnAgregarPizza.Location = new System.Drawing.Point(210, 185);
            this.btnAgregarPizza.Name = "btnAgregarPizza";
            this.btnAgregarPizza.Size = new System.Drawing.Size(129, 49);
            this.btnAgregarPizza.TabIndex = 9;
            this.btnAgregarPizza.Text = "Agregar al Pedido";
            this.btnAgregarPizza.UseVisualStyleBackColor = true;
            this.btnAgregarPizza.Click += new System.EventHandler(this.btnAgregarPizza_Click);
            // 
            // listPizzas
            // 
            this.listPizzas.FormattingEnabled = true;
            this.listPizzas.ItemHeight = 16;
            this.listPizzas.Location = new System.Drawing.Point(395, 12);
            this.listPizzas.Name = "listPizzas";
            this.listPizzas.Size = new System.Drawing.Size(481, 244);
            this.listPizzas.TabIndex = 10;
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(210, 38);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(120, 22);
            this.numericCantidad.TabIndex = 11;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 419);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.listPizzas);
            this.Controls.Add(this.btnAgregarPizza);
            this.Controls.Add(this.chkbEnvio);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.lblCoccion);
            this.Controls.Add(this.cmbTipoCoccion);
            this.Controls.Add(this.lblGustos);
            this.Controls.Add(this.cmbGustoPizza);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCrearPedido);
            this.Name = "frmPedidos";
            this.Text = "Pedidos Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearPedido;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblGustos;
        private System.Windows.Forms.ComboBox cmbGustoPizza;
        private System.Windows.Forms.Label lblCoccion;
        private System.Windows.Forms.ComboBox cmbTipoCoccion;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.CheckBox chkbEnvio;
        private System.Windows.Forms.Button btnAgregarPizza;
        private System.Windows.Forms.ListBox listPizzas;
        private System.Windows.Forms.NumericUpDown numericCantidad;
    }
}