namespace PracticaDelegados
{
    partial class FrmEnvia
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
            this.txtEnvia = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnvia
            // 
            this.txtEnvia.Location = new System.Drawing.Point(82, 62);
            this.txtEnvia.Name = "txtEnvia";
            this.txtEnvia.Size = new System.Drawing.Size(100, 22);
            this.txtEnvia.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(82, 188);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 43);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmEnvia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 284);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtEnvia);
            this.Name = "FrmEnvia";
            this.Text = "FrmEnvia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnvia;
        private System.Windows.Forms.Button btnAceptar;
    }
}