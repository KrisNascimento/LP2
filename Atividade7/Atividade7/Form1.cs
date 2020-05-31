using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string valor = "";
            string auxiliar = "";

            for (int x=0; x>20; x++)
            {
                valor = Interaction.InputBox("Digite o número da posição:",(x+1),
                    "Entrada de dados");
                if (valor == "") //cancelar
                    break;

                if (int.TryParse(valor, out Vetor[x]))
                {
                    //auxiliar = auxiliar + "\n" + Vetor[x].ToString();
                    auxiliar = Vetor[x].ToString() + "\n" + auxiliar;
                }
                else
                {
                    MessageBox.Show("Número Inválido!");
                    x--;
                }
            }
            MessageBox.Show(auxiliar);
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string valor = "";
            string auxiliar = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o número da posição:", (x + 1),
                    "Entrada de dados");
                if (valor == "") //cancelar
                    break;

                if (int.TryParse(valor, out Vetor[x]))
                {
                    MessageBox.Show("Número Inválido!");
                    x--;
                }
            }
            Array.Reverse(Vetor);
            for (var x = 0; x < 20;  x++)
                auxiliar = auxiliar + "\n" + Vetor[x];
            MessageBox.Show(auxiliar);
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double[] qtde = new double[10];
            double[] valor = new double[10];
            double valfinal = 0;
            string itens = "";

            for (var x = 0; x < 10; x++)
            {
                itens = Interaction.InputBox("Informa a quantidade de mercadorias " + (x + 1),
                    "Entrada de dados");
                if (double.TryParse(itens, out qtde[x]))
                {
                    while (true)
                    {
                        itens = Interaction.InputBox("Informe os valores das mercadorias" + (x + 1),
                            "Entrada de dados");
                        if (double.TryParse(itens, out valor[x]))
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Informe valores válidos para a marcadoria: " + (x+1));
                        }
                    }
                    valfinal += qtde[x] * valor[x];
                }
                MessageBox.Show("O faturamento final em reais é: " + valfinal.ToString());

            }
        }
    }
}
