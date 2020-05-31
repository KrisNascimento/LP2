namespace Atividade6
{
    partial class frmExercício3
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
            this.lblTeste = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtEntradaTexto = new System.Windows.Forms.TextBox();
            this.btnTestePalindromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeste.Location = new System.Drawing.Point(42, 135);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(140, 22);
            this.lblTeste.TabIndex = 0;
            this.lblTeste.Text = "DIGITE AQUI:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(243, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(298, 22);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "O QUE VOCÊ QUER INVERTER?";
            // 
            // txtEntradaTexto
            // 
            this.txtEntradaTexto.Location = new System.Drawing.Point(199, 138);
            this.txtEntradaTexto.Name = "txtEntradaTexto";
            this.txtEntradaTexto.Size = new System.Drawing.Size(574, 20);
            this.txtEntradaTexto.TabIndex = 2;
            // 
            // btnTestePalindromo
            // 
            this.btnTestePalindromo.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestePalindromo.Location = new System.Drawing.Point(247, 216);
            this.btnTestePalindromo.Name = "btnTestePalindromo";
            this.btnTestePalindromo.Size = new System.Drawing.Size(250, 101);
            this.btnTestePalindromo.TabIndex = 3;
            this.btnTestePalindromo.Text = "É UM PALÍNDROMO?";
            this.btnTestePalindromo.UseVisualStyleBackColor = true;
            this.btnTestePalindromo.Click += new System.EventHandler(this.btnTextoInvertido_Click);
            // 
            // frmExercício3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestePalindromo);
            this.Controls.Add(this.txtEntradaTexto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTeste);
            this.Name = "frmExercício3";
            this.Text = "frmExercício3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtEntradaTexto;
        private System.Windows.Forms.Button btnTestePalindromo;
    }
}