namespace PracticaDelegados
{
    partial class FrmRecibe
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
            this.lblRecibe = new System.Windows.Forms.Label();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecibe
            // 
            this.lblRecibe.AutoSize = true;
            this.lblRecibe.Location = new System.Drawing.Point(92, 47);
            this.lblRecibe.Name = "lblRecibe";
            this.lblRecibe.Size = new System.Drawing.Size(61, 17);
            this.lblRecibe.TabIndex = 0;
            this.lblRecibe.Text = "Mensaje";
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(204, 118);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(36, 36);
            this.btnCuatro.TabIndex = 12;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            //this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(140, 118);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(36, 36);
            this.btnTres.TabIndex = 11;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            //this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(79, 118);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(36, 36);
            this.btnDos.TabIndex = 10;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            //this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(27, 118);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(36, 36);
            this.btnUno.TabIndex = 9;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // FrmRecibe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 272);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.lblRecibe);
            this.Name = "FrmRecibe";
            this.Text = "FrmRecibe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecibe;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
    }
}