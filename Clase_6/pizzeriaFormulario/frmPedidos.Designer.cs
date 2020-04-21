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
            this.cmbCantPizzas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGustoPizza = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoCoccion = new System.Windows.Forms.ComboBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.chkbEnvio = new System.Windows.Forms.CheckBox();
            this.btnAgregarPizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Location = new System.Drawing.Point(145, 352);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(109, 23);
            this.btnCrearPedido.TabIndex = 0;
            this.btnCrearPedido.Text = "Crear Pedido";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            // 
            // cmbCantPizzas
            // 
            this.cmbCantPizzas.FormattingEnabled = true;
            this.cmbCantPizzas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbCantPizzas.Location = new System.Drawing.Point(199, 112);
            this.cmbCantPizzas.Name = "cmbCantPizzas";
            this.cmbCantPizzas.Size = new System.Drawing.Size(121, 24);
            this.cmbCantPizzas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 169);
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
            this.cmbGustoPizza.Location = new System.Drawing.Point(199, 169);
            this.cmbGustoPizza.Name = "cmbGustoPizza";
            this.cmbGustoPizza.Size = new System.Drawing.Size(121, 24);
            this.cmbGustoPizza.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 238);
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
            this.cmbTipoCoccion.Location = new System.Drawing.Point(199, 238);
            this.cmbTipoCoccion.Name = "cmbTipoCoccion";
            this.cmbTipoCoccion.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoCoccion.TabIndex = 5;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(295, 352);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(101, 23);
            this.btnCancelarPedido.TabIndex = 7;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // chkbEnvio
            // 
            this.chkbEnvio.AutoSize = true;
            this.chkbEnvio.Location = new System.Drawing.Point(69, 299);
            this.chkbEnvio.Name = "chkbEnvio";
            this.chkbEnvio.Size = new System.Drawing.Size(135, 21);
            this.chkbEnvio.TabIndex = 8;
            this.chkbEnvio.Text = "Envia a domicilio";
            this.chkbEnvio.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPizza
            // 
            this.btnAgregarPizza.Location = new System.Drawing.Point(257, 297);
            this.btnAgregarPizza.Name = "btnAgregarPizza";
            this.btnAgregarPizza.Size = new System.Drawing.Size(119, 23);
            this.btnAgregarPizza.TabIndex = 9;
            this.btnAgregarPizza.Text = "Agregar";
            this.btnAgregarPizza.UseVisualStyleBackColor = true;
            this.btnAgregarPizza.Click += new System.EventHandler(this.btnAgregarPizza_Click);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 409);
            this.Controls.Add(this.btnAgregarPizza);
            this.Controls.Add(this.chkbEnvio);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoCoccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGustoPizza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCantPizzas);
            this.Controls.Add(this.btnCrearPedido);
            this.Name = "frmPedidos";
            this.Text = "Pedidos Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearPedido;
        private System.Windows.Forms.ComboBox cmbCantPizzas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGustoPizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoCoccion;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.CheckBox chkbEnvio;
        private System.Windows.Forms.Button btnAgregarPizza;
    }
}