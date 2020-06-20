namespace Prova
{
    partial class frmProva
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
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lstbxTotais = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVerifica
            // 
            this.btnVerifica.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica.Location = new System.Drawing.Point(62, 96);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(212, 90);
            this.btnVerifica.TabIndex = 0;
            this.btnVerifica.Text = "CALCULAR";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lstbxTotais
            // 
            this.lstbxTotais.FormattingEnabled = true;
            this.lstbxTotais.Location = new System.Drawing.Point(358, 13);
            this.lstbxTotais.Name = "lstbxTotais";
            this.lstbxTotais.Size = new System.Drawing.Size(389, 329);
            this.lstbxTotais.TabIndex = 1;
            // 
            // frmProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbxTotais);
            this.Controls.Add(this.btnVerifica);
            this.Name = "frmProva";
            this.Text = "Prova";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.ListBox lstbxTotais;
    }
}

