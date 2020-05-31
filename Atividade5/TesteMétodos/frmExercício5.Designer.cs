namespace TesteMétodos
{
    partial class frmExercício5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercício5));
            this.btnSorteio = new System.Windows.Forms.Button();
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.lblSegndo = new System.Windows.Forms.Label();
            this.txtPrimeiro = new System.Windows.Forms.TextBox();
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSorteio
            // 
            this.btnSorteio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSorteio.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorteio.Location = new System.Drawing.Point(345, 169);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(145, 98);
            this.btnSorteio.TabIndex = 0;
            this.btnSorteio.Text = "Realizar Sorteio";
            this.btnSorteio.UseVisualStyleBackColor = false;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblPrimeiro.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiro.Location = new System.Drawing.Point(72, 59);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(174, 19);
            this.lblPrimeiro.TabIndex = 1;
            this.lblPrimeiro.Text = "Primeiro Número";
            // 
            // lblSegndo
            // 
            this.lblSegndo.AutoSize = true;
            this.lblSegndo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSegndo.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegndo.Location = new System.Drawing.Point(72, 116);
            this.lblSegndo.Name = "lblSegndo";
            this.lblSegndo.Size = new System.Drawing.Size(163, 19);
            this.lblSegndo.TabIndex = 2;
            this.lblSegndo.Text = "Segundo Número";
            // 
            // txtPrimeiro
            // 
            this.txtPrimeiro.Location = new System.Drawing.Point(345, 58);
            this.txtPrimeiro.Name = "txtPrimeiro";
            this.txtPrimeiro.Size = new System.Drawing.Size(145, 20);
            this.txtPrimeiro.TabIndex = 3;
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(345, 118);
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(145, 20);
            this.txtSegundo.TabIndex = 4;
            // 
            // frmExercício5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.txtSegundo);
            this.Controls.Add(this.txtPrimeiro);
            this.Controls.Add(this.lblSegndo);
            this.Controls.Add(this.lblPrimeiro);
            this.Controls.Add(this.btnSorteio);
            this.Name = "frmExercício5";
            this.Text = "frmExercício5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSorteio;
        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.Label lblSegndo;
        private System.Windows.Forms.TextBox txtPrimeiro;
        private System.Windows.Forms.TextBox txtSegundo;
    }
}