namespace EjercitacionDelegadosEventos
{
    partial class Form1
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
            this.txtJug1 = new System.Windows.Forms.TextBox();
            this.txtJug2 = new System.Windows.Forms.TextBox();
            this.txtJug3 = new System.Windows.Forms.TextBox();
            this.txtJug4 = new System.Windows.Forms.TextBox();
            this.btnJug1 = new System.Windows.Forms.Button();
            this.btnJug2 = new System.Windows.Forms.Button();
            this.btnJug3 = new System.Windows.Forms.Button();
            this.btnJug4 = new System.Windows.Forms.Button();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtJug1
            // 
            this.txtJug1.Location = new System.Drawing.Point(19, 55);
            this.txtJug1.Name = "txtJug1";
            this.txtJug1.Size = new System.Drawing.Size(116, 22);
            this.txtJug1.TabIndex = 0;
            // 
            // txtJug2
            // 
            this.txtJug2.Location = new System.Drawing.Point(167, 55);
            this.txtJug2.Name = "txtJug2";
            this.txtJug2.Size = new System.Drawing.Size(116, 22);
            this.txtJug2.TabIndex = 1;
            // 
            // txtJug3
            // 
            this.txtJug3.Location = new System.Drawing.Point(324, 55);
            this.txtJug3.Name = "txtJug3";
            this.txtJug3.Size = new System.Drawing.Size(116, 22);
            this.txtJug3.TabIndex = 2;
            // 
            // txtJug4
            // 
            this.txtJug4.Location = new System.Drawing.Point(485, 55);
            this.txtJug4.Name = "txtJug4";
            this.txtJug4.Size = new System.Drawing.Size(116, 22);
            this.txtJug4.TabIndex = 3;
            // 
            // btnJug1
            // 
            this.btnJug1.Location = new System.Drawing.Point(19, 158);
            this.btnJug1.Name = "btnJug1";
            this.btnJug1.Size = new System.Drawing.Size(116, 50);
            this.btnJug1.TabIndex = 4;
            this.btnJug1.Text = "Jugador Uno";
            this.btnJug1.UseVisualStyleBackColor = true;
            // 
            // btnJug2
            // 
            this.btnJug2.Location = new System.Drawing.Point(167, 158);
            this.btnJug2.Name = "btnJug2";
            this.btnJug2.Size = new System.Drawing.Size(116, 50);
            this.btnJug2.TabIndex = 5;
            this.btnJug2.Text = "Jugador Dos";
            this.btnJug2.UseVisualStyleBackColor = true;
            // 
            // btnJug3
            // 
            this.btnJug3.Location = new System.Drawing.Point(324, 158);
            this.btnJug3.Name = "btnJug3";
            this.btnJug3.Size = new System.Drawing.Size(116, 50);
            this.btnJug3.TabIndex = 6;
            this.btnJug3.Text = "Jugador Tres";
            this.btnJug3.UseVisualStyleBackColor = true;
            // 
            // btnJug4
            // 
            this.btnJug4.Location = new System.Drawing.Point(485, 158);
            this.btnJug4.Name = "btnJug4";
            this.btnJug4.Size = new System.Drawing.Size(116, 50);
            this.btnJug4.TabIndex = 7;
            this.btnJug4.Text = "Jugador Cuatro";
            this.btnJug4.UseVisualStyleBackColor = true;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(105, 294);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(116, 50);
            this.btnEmpezar.TabIndex = 8;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(452, 299);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(52, 17);
            this.lblPuntaje.TabIndex = 9;
            this.lblPuntaje.Text = "Puntos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 363);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.btnJug4);
            this.Controls.Add(this.btnJug3);
            this.Controls.Add(this.btnJug2);
            this.Controls.Add(this.btnJug1);
            this.Controls.Add(this.txtJug4);
            this.Controls.Add(this.txtJug3);
            this.Controls.Add(this.txtJug2);
            this.Controls.Add(this.txtJug1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJug1;
        private System.Windows.Forms.TextBox txtJug2;
        private System.Windows.Forms.TextBox txtJug3;
        private System.Windows.Forms.TextBox txtJug4;
        private System.Windows.Forms.Button btnJug1;
        private System.Windows.Forms.Button btnJug2;
        private System.Windows.Forms.Button btnJug3;
        private System.Windows.Forms.Button btnJug4;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label lblPuntaje;
    }
}

