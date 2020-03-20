namespace PesoIdeal
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbxGênero = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.txtPesoIdeal = new System.Windows.Forms.TextBox();
            this.txtOqfazer = new System.Windows.Forms.TextBox();
            this.lblOqfazer = new System.Windows.Forms.Label();
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.mskbxPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.gbxGênero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(164, 57);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(69, 20);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(164, 106);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(102, 20);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso Atual";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalcular.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(472, 12);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(126, 83);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbxGênero
            // 
            this.gbxGênero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxGênero.Controls.Add(this.rbtnMasculino);
            this.gbxGênero.Controls.Add(this.rbtnFeminino);
            this.gbxGênero.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGênero.Location = new System.Drawing.Point(12, 12);
            this.gbxGênero.Name = "gbxGênero";
            this.gbxGênero.Size = new System.Drawing.Size(127, 130);
            this.gbxGênero.TabIndex = 5;
            this.gbxGênero.TabStop = false;
            this.gbxGênero.Text = "Gênero";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(7, 90);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(119, 24);
            this.rbtnMasculino.TabIndex = 3;
            this.rbtnMasculino.Text = "MASCULINO";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Checked = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(7, 41);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(106, 24);
            this.rbtnFeminino.TabIndex = 2;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "FEMININO";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoIdeal.Location = new System.Drawing.Point(8, 260);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(98, 20);
            this.lblPesoIdeal.TabIndex = 6;
            this.lblPesoIdeal.Text = "PESO iDEAL";
            // 
            // txtPesoIdeal
            // 
            this.txtPesoIdeal.Location = new System.Drawing.Point(133, 263);
            this.txtPesoIdeal.Name = "txtPesoIdeal";
            this.txtPesoIdeal.ReadOnly = true;
            this.txtPesoIdeal.Size = new System.Drawing.Size(100, 20);
            this.txtPesoIdeal.TabIndex = 7;
            // 
            // txtOqfazer
            // 
            this.txtOqfazer.Location = new System.Drawing.Point(133, 312);
            this.txtOqfazer.Name = "txtOqfazer";
            this.txtOqfazer.ReadOnly = true;
            this.txtOqfazer.Size = new System.Drawing.Size(213, 20);
            this.txtOqfazer.TabIndex = 8;
            // 
            // lblOqfazer
            // 
            this.lblOqfazer.AutoSize = true;
            this.lblOqfazer.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOqfazer.Location = new System.Drawing.Point(8, 312);
            this.lblOqfazer.Name = "lblOqfazer";
            this.lblOqfazer.Size = new System.Drawing.Size(108, 20);
            this.lblOqfazer.TabIndex = 9;
            this.lblOqfazer.Text = "O que fazer";
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Location = new System.Drawing.Point(273, 60);
            this.mskbxAltura.Mask = "0.00";
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(100, 20);
            this.mskbxAltura.TabIndex = 10;
            this.mskbxAltura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskbxAltura_MaskInputRejected);
            // 
            // mskbxPesoAtual
            // 
            this.mskbxPesoAtual.Location = new System.Drawing.Point(273, 106);
            this.mskbxPesoAtual.Mask = "000";
            this.mskbxPesoAtual.Name = "mskbxPesoAtual";
            this.mskbxPesoAtual.Size = new System.Drawing.Size(100, 20);
            this.mskbxPesoAtual.TabIndex = 11;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(472, 260);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(126, 83);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(11, 197);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(127, 33);
            this.btnResultado.TabIndex = 13;
            this.btnResultado.Text = "RESULTADO";
            this.btnResultado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 453);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.mskbxPesoAtual);
            this.Controls.Add(this.mskbxAltura);
            this.Controls.Add(this.lblOqfazer);
            this.Controls.Add(this.txtOqfazer);
            this.Controls.Add(this.txtPesoIdeal);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.gbxGênero);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxGênero.ResumeLayout(false);
            this.gbxGênero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbxGênero;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.TextBox txtPesoIdeal;
        private System.Windows.Forms.TextBox txtOqfazer;
        private System.Windows.Forms.Label lblOqfazer;
        private System.Windows.Forms.MaskedTextBox mskbxAltura;
        private System.Windows.Forms.MaskedTextBox mskbxPesoAtual;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnResultado;
    }
}

