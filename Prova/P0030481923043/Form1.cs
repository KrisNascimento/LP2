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
using System.Collections;

namespace Prova
{
    public partial class frmProva : Form
    {
        public frmProva()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            lstbxTotais.Items.Clear();
            double[,] vendas = new double[3, 4];
            double totalMes, totalGeral;
            string valor;
            

            totalGeral = 0;
            for (int lin = 0; lin < 4; lin++)
            {
                totalMes = 0;
                for (int col = 0; col < 4; col++)
                {
                    valor = Interaction.InputBox("Informe o total de vendas da semana " + (col + 1) + " do mês " + (lin + 1) + ":", "Entrada das Valores");
                    if (double.TryParse(valor, out vendas[lin, col]))
                    {
                        lstbxTotais.Items.Add("Total do mês:" + (lin + 1) + " Semana:" + (col + 1) + " R$" + vendas[lin, col].ToString("N2"));
                        totalMes += vendas[lin, col];
                    }
                    else
                    {
                        MessageBox.Show("Digite valores válidos!!!");
                        col--;
                    }
                }
                lstbxTotais.Items.Add(">> Total Mês:" + "R$" + totalMes.ToString("N2"));
                lstbxTotais.Items.Add("-------------------------------------");
                totalGeral += totalMes;
            }
            lstbxTotais.Items.Add(">> Total Geral:" + "R$" + totalGeral.ToString("N2"));

        }
    }
}
