using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class frmExercício1 : Form
    {
        public frmExercício1()
        {
            InitializeComponent();
        }

        private void btnBrancos_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (var x = 0; x <= rchtxtFrase.Text.Length - 1; x++)
            {

                if (Char.IsWhiteSpace(rchtxtFrase.Text[x]))
                    contador += 1;
            }

            MessageBox.Show("Este texto tem : " + contador + " espaços em branco");
        }

        private void btnLetrasR_Click(object sender, EventArgs e)
        {
            string texto = rchtxtFrase.Text;

            int conf = texto.Split('r').Length;

            int resultado = conf - (1);

           MessageBox.Show("Neste texto aparecem " + resultado.ToString() + " letras r");
           
        }

        private void btnDigrafos_Click(object sender, EventArgs e)
        {
                  
            string frase = rchtxtFrase.Text;
            int tfrase = rchtxtFrase.Text.Length;
            int n = 1;
            int contador = 0;

            if (tfrase > 1)
            {
                while (n < rchtxtFrase.Text.Length)
                {
                    if (Char.ToUpper(rchtxtFrase.Text[n]) == Char.ToUpper(rchtxtFrase.Text[n - 1]))
                        contador++;
                    n++;
                }
            }                
                MessageBox.Show("Nesta frase, existem " + contador + " pares de letras iguais");
                

            }
        }
    }

