namespace Atividade6
{
    partial class frmExercício2
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
            this.txtValorN = new System.Windows.Forms.TextBox();
            this.btnGerarNum = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorN
            // 
            this.txtValorN.Location = new System.Drawing.Point(441, 123);
            this.txtValorN.Name = "txtValorN";
            this.txtValorN.Size = new System.Drawing.Size(171, 20);
            this.txtValorN.TabIndex = 0;
            // 
            // btnGerarNum
            // 
            this.btnGerarNum.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarNum.Location = new System.Drawing.Point(350, 199);
            this.btnGerarNum.Name = "btnGerarNum";
            this.btnGerarNum.Size = new System.Drawing.Size(171, 117);
            this.btnGerarNum.TabIndex = 1;
            this.btnGerarNum.Text = "O RESULTADO DE H É";
            this.btnGerarNum.UseVisualStyleBackColor = true;
            this.btnGerarNum.Click += new System.EventHandler(this.btnGerarNum_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(181, 120);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(245, 22);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Informe um número n";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(90, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(599, 22);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "CALCULA UM NÚMERO \'H\' ATRAVÉS DE UM NÚMERO \'N\' INFORMADO";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.Location = new System.Drawing.Point(241, 57);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(297, 22);
            this.lblFormula.TabIndex = 4;
            this.lblFormula.Text = "H = 1 + 1/2 +1/3+1/4+1/5+...+1/N";
            // 
            // frmExercício2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnGerarNum);
            this.Controls.Add(this.txtValorN);
            this.Name = "frmExercício2";
            this.Text = "frmExercício2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorN;
        private System.Windows.Forms.Button btnGerarNum;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFormula;
    }
}