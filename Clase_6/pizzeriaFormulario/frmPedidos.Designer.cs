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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGustoPizza = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoCoccion = new System.Windows.Forms.ComboBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.chkbEnvio = new System.Windows.Forms.CheckBox();
            this.btnAgregarPizza = new System.Windows.Forms.Button();
            this.lstPizzas = new System.Windows.Forms.ListBox();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Location = new System.Drawing.Point(471, 352);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(109, 23);
            this.btnCrearPedido.TabIndex = 0;
            this.btnCrearPedido.Text = "Crear Pedido";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cargue los gustos";
            // 
            // cmbGustoPizza
            // 
            this.cmbGustoPizza.FormattingEnabled = true;
            this.cmbGustoPizza.Items.AddRange(new object[] {
            "Muzzarella",
            "Jamon y Morron",
            "Fugazzeta",
            "Cantipalo"});
            this.cmbGustoPizza.Location = new System.Drawing.Point(188, 112);
            this.cmbGustoPizza.Name = "cmbGustoPizza";
            this.cmbGustoPizza.Size = new System.Drawing.Size(121, 24);
            this.cmbGustoPizza.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Coccion";
            // 
            // cmbTipoCoccion
            // 
            this.cmbTipoCoccion.FormattingEnabled = true;
            this.cmbTipoCoccion.Items.AddRange(new object[] {
            "A la Piedra",
            "Al Molde"});
            this.cmbTipoCoccion.Location = new System.Drawing.Point(188, 181);
            this.cmbTipoCoccion.Name = "cmbTipoCoccion";
            this.cmbTipoCoccion.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoCoccion.TabIndex = 5;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(603, 352);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(101, 23);
            this.btnCancelarPedido.TabIndex = 7;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // chkbEnvio
            // 
            this.chkbEnvio.AutoSize = true;
            this.chkbEnvio.Location = new System.Drawing.Point(35, 260);
            this.chkbEnvio.Name = "chkbEnvio";
            this.chkbEnvio.Size = new System.Drawing.Size(135, 21);
            this.chkbEnvio.TabIndex = 8;
            this.chkbEnvio.Text = "Envia a domicilio";
            this.chkbEnvio.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPizza
            // 
            this.btnAgregarPizza.Location = new System.Drawing.Point(223, 258);
            this.btnAgregarPizza.Name = "btnAgregarPizza";
            this.btnAgregarPizza.Size = new System.Drawing.Size(119, 23);
            this.btnAgregarPizza.TabIndex = 9;
            this.btnAgregarPizza.Text = "Agregar";
            this.btnAgregarPizza.UseVisualStyleBackColor = true;
            this.btnAgregarPizza.Click += new System.EventHandler(this.btnAgregarPizza_Click);
            // 
            // lstPizzas
            // 
            this.lstPizzas.FormattingEnabled = true;
            this.lstPizzas.ItemHeight = 16;
            this.lstPizzas.Location = new System.Drawing.Point(388, 55);
            this.lstPizzas.Name = "lstPizzas";
            this.lstPizzas.Size = new System.Drawing.Size(270, 228);
            this.lstPizzas.TabIndex = 10;
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(189, 55);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(120, 22);
            this.numericCantidad.TabIndex = 11;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 409);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.lstPizzas);
            this.Controls.Add(this.btnAgregarPizza);
            this.Controls.Add(this.chkbEnvio);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoCoccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGustoPizza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearPedido);
            this.Name = "frmPedidos";
            this.Text = "Pedidos Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGustoPizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoCoccion;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.CheckBox chkbEnvio;
        private System.Windows.Forms.Button btnAgregarPizza;
        private System.Windows.Forms.ListBox lstPizzas;
        private System.Windows.Forms.NumericUpDown numericCantidad;
    }
}