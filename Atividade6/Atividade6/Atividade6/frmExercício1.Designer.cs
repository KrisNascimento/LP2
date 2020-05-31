namespace Atividade6
{
    partial class frmExercício1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnBrancos = new System.Windows.Forms.Button();
            this.btnLetrasR = new System.Windows.Forms.Button();
            this.btnDigrafos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(13, 12);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(775, 187);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnBrancos
            // 
            this.btnBrancos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrancos.Location = new System.Drawing.Point(91, 207);
            this.btnBrancos.Name = "btnBrancos";
            this.btnBrancos.Size = new System.Drawing.Size(196, 68);
            this.btnBrancos.TabIndex = 1;
            this.btnBrancos.Text = "Contar os espaços em branco";
            this.btnBrancos.UseVisualStyleBackColor = true;
            this.btnBrancos.Click += new System.EventHandler(this.btnBrancos_Click);
            // 
            // btnLetrasR
            // 
            this.btnLetrasR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetrasR.Location = new System.Drawing.Point(297, 237);
            this.btnLetrasR.Name = "btnLetrasR";
            this.btnLetrasR.Size = new System.Drawing.Size(196, 68);
            this.btnLetrasR.TabIndex = 2;
            this.btnLetrasR.Text = "Contar as letras \'R\'";
            this.btnLetrasR.UseVisualStyleBackColor = true;
            this.btnLetrasR.Click += new System.EventHandler(this.btnLetrasR_Click);
            // 
            // btnDigrafos
            // 
            this.btnDigrafos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigrafos.Location = new System.Drawing.Point(504, 267);
            this.btnDigrafos.Name = "btnDigrafos";
            this.btnDigrafos.Size = new System.Drawing.Size(196, 68);
            this.btnDigrafos.TabIndex = 3;
            this.btnDigrafos.Text = "Contar os pares iguais";
            this.btnDigrafos.UseVisualStyleBackColor = true;
            this.btnDigrafos.Click += new System.EventHandler(this.btnDigrafos_Click);
            // 
            // frmExercício1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDigrafos);
            this.Controls.Add(this.btnLetrasR);
            this.Controls.Add(this.btnBrancos);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercício1";
            this.Text = "frmExercício1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnBrancos;
        private System.Windows.Forms.Button btnLetrasR;
        private System.Windows.Forms.Button btnDigrafos;
    }
}