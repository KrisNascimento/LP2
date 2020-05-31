namespace TesteMétodos
{
    partial class frmExercício4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercício4));
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnCaracNum = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnCaracAlfabet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rchtxtTexto.Location = new System.Drawing.Point(51, 8);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(703, 171);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnCaracNum
            // 
            this.btnCaracNum.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaracNum.Location = new System.Drawing.Point(51, 198);
            this.btnCaracNum.Name = "btnCaracNum";
            this.btnCaracNum.Size = new System.Drawing.Size(194, 109);
            this.btnCaracNum.TabIndex = 1;
            this.btnCaracNum.Text = "Caracteres Numéricos";
            this.btnCaracNum.UseVisualStyleBackColor = true;
            this.btnCaracNum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.Location = new System.Drawing.Point(305, 198);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(194, 109);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Primeiro Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCaracAlfabet
            // 
            this.btnCaracAlfabet.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaracAlfabet.Location = new System.Drawing.Point(560, 198);
            this.btnCaracAlfabet.Name = "btnCaracAlfabet";
            this.btnCaracAlfabet.Size = new System.Drawing.Size(194, 109);
            this.btnCaracAlfabet.TabIndex = 3;
            this.btnCaracAlfabet.Text = "Caracteres Alfabéticos";
            this.btnCaracAlfabet.UseVisualStyleBackColor = true;
            this.btnCaracAlfabet.Click += new System.EventHandler(this.Button3_Click);
            // 
            // frmExercício4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCaracAlfabet);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnCaracNum);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercício4";
            this.Text = "frmExercício4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnCaracNum;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnCaracAlfabet;
    }
}