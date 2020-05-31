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
    public partial class frmExercício3 : Form
    {
        public frmExercício3()
        {
            InitializeComponent();
        }

        private void btnTextoInvertido_Click(object sender, EventArgs e)
        {
            string entrada = txtEntradaTexto.Text.Replace(" ", "");
            string inversa = "";
            char[] reversa = entrada.ToCharArray();
            int tamanho = entrada.Length;

            if (tamanho < 50)
            {
                entrada = entrada.ToUpper();
                Array.Reverse(reversa);

                foreach (char letra in reversa)
                {
                    inversa = inversa + letra.ToString();
                }
                if (string.Compare(entrada, inversa, true) == 0)
                {
                    MessageBox.Show("Este texto é um Palíndromo!");
                }
                else
                    MessageBox.Show("Este texto não é um Palíndromo!");
            }

        }

    }
}
